using ECommerce.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Admin.Filters
{
    public class IsLogin:ActionFilterAttribute,IActionFilter
    {
       /* private IUserService _userService;

        public IsLogin(IUserService userService)
        {
            _userService = userService;
        }*/
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //_userService.GetUserById(_userId)!=null
            var _userId = context.HttpContext.Session.GetString("Login");
            if (!string.IsNullOrEmpty(_userId))//TODO:! işareti kaldırılacak.
            {
                context.Result = new RedirectResult("/User/Login");
            }
        }
    }
}
