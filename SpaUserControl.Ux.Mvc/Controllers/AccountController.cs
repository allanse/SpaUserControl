using SpaUserControl.Domain.Contracts.Services;
using SpaUserControl.Ux.Mvc.Models;
using System;
using System.Web.Mvc;

namespace SpaUserControl.Ux.Mvc.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _service;

        public AccountController(IUserService service)
        {
            this._service = service;
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterUserModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            try
            {
                _service.Register(model.Name, model.Email, model.Password, model.ConfirmPassword);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("DefaultErrorMessage", ex.Message);
                return View(model);
            }
        }

        protected override void Dispose(bool disposing)
        {
            _service.Dispose();
        }
    }
}
