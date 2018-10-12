using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Filters
{
    public class CustomFilter : Attribute, IActionFilter
    {

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //int i = 20;
        }


        public void OnActionExecuted(ActionExecutedContext context)
        {
            //int i = 30;
        }


    }
}
