using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Identity;
using MyApplication.Models;
using MyApplication.Models.Security;

namespace MyApplication.Controllers
{
    public class SecurityController : Controller
    {
        private readonly ToursDbContext _toursDbContext;

        private UserManager<AppIdentityUser> _userManager;

        private SignInManager<AppIdentityUser> _signInManager;
        public SecurityController(UserManager<AppIdentityUser> userManager, SignInManager<AppIdentityUser> signInManager, ToursDbContext toursDbContext)
        {
            _toursDbContext = toursDbContext;

            _userManager = userManager;

            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            if (!ModelState.IsValid)
            {
                return View(loginViewModel);
            }

            var user = await _userManager.FindByEmailAsync(loginViewModel.Email);
            if (user != null)
            {
                if (!await _userManager.IsEmailConfirmedAsync(user))
                {
                    ModelState.AddModelError(String.Empty, "Confirm your Email");

                    return View(loginViewModel);
                }
            }

            var result = await _signInManager.PasswordSignInAsync(loginViewModel.Email, 
                            loginViewModel.Password, false, true);

            if(result.Succeeded)
            {
                return RedirectToAction("Incoming", "Service");
            }

            ModelState.AddModelError(String.Empty, "Login Failed");

            return View(loginViewModel);
        }

        public async Task<IActionResult> Logout()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "DemoStudent");
        }

        public IActionResult AccessDenied()
        {
            
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            
            if (!ModelState.IsValid)
            {
                return View(registerViewModel);
            }

            var user = new AppIdentityUser()
            {
                 FirstName = registerViewModel.FirstName,

                 LastName = registerViewModel.LastName,

                 Email = registerViewModel.Email,

                 UserName = registerViewModel.Email
                

            };

            var result = await _userManager.CreateAsync(user, registerViewModel.Password);

            if(result.Succeeded)

            {
                var confirmationCode = _userManager.GenerateEmailConfirmationTokenAsync(user);

                var callbackUrl = Url.Action("ConfirmEmail", "Security", new { userId = user.Id, code = confirmationCode.Result});

                //send Email

                return RedirectToAction("Azerbaijan", "Azerbaijan");
            }

            return View(registerViewModel);
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            if (userId==null || code==null)
            {
                return RedirectToAction("Login"); ///burda bashqa error seyfesi yaratmaq olar
            }

            var user = await _userManager.FindByIdAsync(userId);

            if(user==null)
            {
                throw new ApplicationException("Unable to find User");
            }

            var result = await _userManager.ConfirmEmailAsync(user, code);

            if(result.Succeeded)
            {
                return View("ConfirmEmail");
            }

            return RedirectToAction("Transfer", "Service");
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            if (string.IsNullOrEmpty(email))
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(email);

            if(user==null)
            {
                return View();
            }

            var confirmationCode = await _userManager.GeneratePasswordResetTokenAsync(user);

            var callbackUrl = Url.Action("ResetPassword", "Security", new { userId = user.Id, code = confirmationCode });

            //send callback url with email

            return RedirectToAction("ForgotPasswordEmailSent");
        }

        public IActionResult ForgotPasswordEmailSent()
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            return View();
        }

        public IActionResult ResetPassword(string userId, string code)
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            if (userId==null || code == null)
            {
                throw new ApplicationException("User Id or Code must be supplied for Reset Password");
            }

            var model = new ResetPasswordViewModel { Code = code };
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
            ViewBag.Setting = _toursDbContext.Settings.First();
            if (!ModelState.IsValid)
            {
                return View(resetPasswordViewModel);
            }

            var user = await _userManager.FindByEmailAsync(resetPasswordViewModel.Email);

            if (user==null)
            {
                throw new ApplicationException("User not found");
            }

            var result = await _userManager.ResetPasswordAsync(user, resetPasswordViewModel.Code, resetPasswordViewModel.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("ResetPasswordConfirm");
            }

            return View();
        }

        public IActionResult ResetPasswordConfirm()
        {
            return View();
        }
    }
}