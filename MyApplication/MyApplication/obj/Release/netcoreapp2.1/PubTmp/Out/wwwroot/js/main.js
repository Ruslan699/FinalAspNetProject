
$(function() {
    $("#button").click(function (e) {
        e.preventDefault();
        // check name

        if (checkname()) {
            $('#name').css('border-color', 'green')
        } else {
            $('#name').css('border-color', 'red');
            return false;
        }
         // check surname

        if (checksurname()) {
           $('#surname').css('border-color', 'green')
        } else {
             $('#surname').css('border-color', 'red');
            return false;
        }

           // check email

            if (checkemailAdress()) {
            $('#email').css('border-color', 'green')
         } else {
              $('#email').css('border-color', 'red');
            
             return;
         }

         //check mobile

         if(checkPhone())
         {
            $('#number').css('border-color', 'green')
         } else {
             $('#number').css('border-color', 'red');
           
            return;
        }
         

         //check textarea

         if (checkMessage()) {
            $('#message').css('border-color', 'green')
         } else {
              $('#message').css('border-color', 'red');
            
             return;
         }
     
        })
    })

function checkemailAdress() {
    var email = $("#email").val();
    for (var i = 0; i < email.length; i++) {
        if (email[i] == "@") {
            return true;
        } else {
            continue;
        } 
    }
    return false;

    if (email.length >= 8) {
        return true;
    } else {
        return false;
    }
}

function checkname() {
    var ad = $("#name").val();
    if (ad.length >= 2) {
        return true;
    } else {
        return false;
    }
}

function checksurname() {
    var soyad = $("#surname").val();
    if (soyad.length >= 3) {
        return true;
    } else {
        return false;
    }
}
function checkPhone()
{
    var num = $("#number").val();
    num.replace(/[^0-9]/g,'');
    if (num.length >= 10) {
        return true;
    } else {
        return false;
    }
}
function checkMessage() {
    var mes = $("#message").val();
    if (mes.length >= 9) {
        return true;
    } else {
        return false;
    }
}
//check brons    
$(function() {
    $("#btnFinish").click(function (e) {
        e.preventDefault();
        // check name
        if (checknam()) {
            $('#bName').css('border-color', 'green')
        } else {
            $('#bName').css('border-color', 'red');
            return;
        }
         // check surname
        if (checksurnam()) {
           $('#bSurname').css('border-color', 'green')
        } else {
             $('#bSurname').css('border-color', 'red');
            return;
        }

        // check email
        
        if (checkemail()) {
            $('#bEmail').css('border-color', 'green')
         } else {
              $('#bEmail').css('border-color', 'red');
            
             return;
         }

         //check number
         if (checknumber()) {
            $('#bNumber').css('border-color', 'green')
         } else {
              $('#bNumber').css('border-color', 'red');
            
             return;
         }

         //check Passport
         if(checkPassport())
         {
             $('#bPassport').css('border-color', 'green')
         } else{
             $('#bPassport').css('border-color', 'red')
         }


        })
    })
function checkemail() {
    var email = $("#bEmail").val();
    for (var i = 0; i < email.length; i++) {
        if (email[i] == "@") {
            return true;
        } else {
            continue;
        } 
    }
    return false;

    if (email.length >= 8) {
        return true;
    } else {
        return false;
    }
}

function checknam() {
    var ad = $("#bName").val();
    if (ad.length >= 2) {
        return true;
    } else {
        return false;
    }
}

function checksurnam() {
    var soyad = $("#bSurname").val();
    if (soyad.length >= 3) {
        return true;
    } else {
        return false;
    }
}

function checknumber() {
    var number = $("#bNumber").val();
    number.replace(/[^0-9]/g,'');
    if (number.length >= 9) {
        return true;
    } else {
        return false;
    }
}


function checkPassport()
{
    var passport = $('#bPassport').val();
    var patt = new RegExp("^([A-Z]){3}([1-9]){1}([0-9]){7}$");
if(patt.test(passport))
{
return true;
}
else
{
return false;
}
}

var $form = $('#payment-form');
$form.find('.subscribe').on('click', payWithStripe);


function payWithStripe(e) {
    e.preventDefault();
    
  
    if (!validator.form()) {
        return;
    }

   
    $form.find('.subscribe').html('Validating <i class="fa fa-spinner fa-pulse"></i>').prop('disabled', true);

    var PublishableKey = 'pk_test_6pRNASCoBOKtIshFeQd4XMUh';
    Stripe.setPublishableKey(PublishableKey);
    
    
    var expiry = $form.find('[name=cardExpiry]').payment('cardExpiryVal');
    var ccData = {
        number: $form.find('[name=cardNumber]').val().replace(/\s/g,''),
        cvc: $form.find('[name=cardCVC]').val(),
        exp_month: expiry.month, 
        exp_year: expiry.year
    };
    
    Stripe.card.createToken(ccData, function stripeResponseHandler(status, response) {
        if (response.error) {
       
            $form.find('.subscribe').html('Try again').prop('disabled', false);
          
            $form.find('.payment-errors').text(response.error.message);
            $form.find('.payment-errors').closest('.row').show();
        } else {
           
            $form.find('.subscribe').html('Processing <i class="fa fa-spinner fa-pulse"></i>');
          
            $form.find('.payment-errors').closest('.row').hide();
            $form.find('.payment-errors').text("");
                        
            console.log(response.id);
            console.log(response.card);
            var token = response.id;
            // AJAX - you would send 'token' to your server here.
            $.post('/account/stripe_card_token', {
                    token: token
                })
                
                .done(function(data, textStatus, jqXHR) {
                    $form.find('.subscribe').html('Payment successful <i class="fa fa-check"></i>');
                })
                .fail(function(jqXHR, textStatus, errorThrown) {
                    $form.find('.subscribe').html('There was a problem').removeClass('success').addClass('error');
                   
                    $form.find('.payment-errors').text('Try refreshing the page and trying again.');
                    $form.find('.payment-errors').closest('.row').show();
                });
        }
    });
}


jQuery.validator.addMethod("cardNumber", function(value, element) {
    return this.optional(element) || Stripe.card.validateCardNumber(value);
}, "Please specify a valid credit card number.");

jQuery.validator.addMethod("cardExpiry", function(value, element) {    

    value = $.payment.cardExpiryVal(value);
    return this.optional(element) || Stripe.card.validateExpiry(value.month, value.year);
}, "Invalid expiration date.");

jQuery.validator.addMethod("cardCVC", function(value, element) {
    return this.optional(element) || Stripe.card.validateCVC(value);
}, "Invalid CVC.");

validator = $form.validate({
    rules: {
        cardNumber: {
            required: true,
            cardNumber: true            
        },
        cardExpiry: {
            required: true,
            cardExpiry: true
        },
        cardCVC: {
            required: true,
            cardCVC: true
        }
    },
    highlight: function(element) {
        $(element).closest('.form-control').removeClass('success').addClass('error');
    },
    unhighlight: function(element) {
        $(element).closest('.form-control').removeClass('error').addClass('success');
    },
    errorPlacement: function(error, element) {
        $(element).closest('.form-group').append(error);
    }
});

paymentFormReady = function() {
    if ($form.find('[name=cardNumber]').hasClass("success") &&
        $form.find('[name=cardExpiry]').hasClass("success") &&
        $form.find('[name=cardCVC]').val().length > 1) {
        return true;
    } else {
        return false;
    }
}

$form.find('.subscribe').prop(true);
var readyInterval = setInterval(function() {
    if (paymentFormReady()){
        $form.find('.subscribe').prop(false);
        clearInterval(readyInterval);
    }
}, 250);