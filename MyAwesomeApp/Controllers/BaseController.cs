﻿using System.Web.Mvc;
using MyAwesomeApp.Models.ViewModels;

namespace MyAwesomeApp.Controllers
{
    public class BaseController : Controller
    {
        protected LayoutViewModel LayoutModel
        {
            get { return (LayoutViewModel)ViewBag.LayoutModel; }
            set { ViewBag.LayoutModel = value; }
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Setup defaults for layout. Can be changed in specific action methods through the LayoutViewModel property.
            LayoutViewModel layoutModel = new LayoutViewModel
            {
                IsLoggedIn = User.Identity.IsAuthenticated
            };

            LayoutModel = layoutModel;

            base.OnActionExecuting(filterContext);
        }
    }
}