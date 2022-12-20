using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebsiteApplication.Models;
using LogicLayer;
using DataLayer;

namespace WebsiteApplication.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public Signin Model { get; set; }
        public UserManager UserManager { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            UserRepository userRepository = new UserRepository();
            UserManager = new UserManager(userRepository);
            if (ModelState.IsValid)
            {
                if (EmailValidation.IsValidEmail(Model.Email))
                {
                    try
                    {
                        if (UserManager.CreateUser(Model.Email, Model.Password, Model.Name, EnumTypeOfUser.CUSTOMER.ToString()) == true)
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
                        else { ModelState.AddModelError("WrongCredentials", "Email is incorrect format"); }
                        if (UserManager.CreateUser(Model.Email, Model.Password, Model.Name, EnumTypeOfUser.CUSTOMER.ToString()) == true)
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
                        else { ModelState.AddModelError("WrongCredentials", "Email is incorrect format");
                        }
                    }
                    catch { ModelState.AddModelError("WrongCredentials", "Email is already taken"); }
                    
                }
            }
            return Page();
        }
    }
}
