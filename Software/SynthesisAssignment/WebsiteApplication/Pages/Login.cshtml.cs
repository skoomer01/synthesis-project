using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System.Reflection;
using WebsiteApplication.Models;


namespace WebsiteApplication.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Login Model { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (EmailValidation.IsValidEmail(Model.Email))
                {
                    try
                    {
                        LoginManager loginManager = new LoginManager();
                        User user = loginManager.Login(Model.Email, Model.Password);

                        if (user is not null)
                        {
                            HttpContext.Session.SetInt32("UserID", user.UserId);
                            HttpContext.Session.SetString("Email", Model.Email);

                            return RedirectToPage("/Index");
                        }
                    }
                    catch
                    {
                        ModelState.AddModelError("Invalid", "Invalid creditentials");
                    }
                }
            }
            return Page();
        }
    }
}
