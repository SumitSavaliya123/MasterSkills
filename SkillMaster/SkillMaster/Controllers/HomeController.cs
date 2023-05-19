using Microsoft.AspNetCore.Mvc;
using SkillMaster.Model.DataModels;
using SkillMaster.Model.ViewModels;
using SkillMaster.Models;
using SkillMaster.Repository.Interface;
using System.Diagnostics;

namespace SkillMaster.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGenericRepository<User> _genericRepository; 

        public HomeController(ILogger<HomeController> logger, IGenericRepository<User> genericRepository)
        {
            _logger = logger;
            _genericRepository = genericRepository;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserRequest model)
        {

            if (ModelState.IsValid)
            {
                //var emailExist = _accountRepository.IsEmailAvailable(loginModel.Email);
                //if (emailExist)
                //{
                //    var user = _accountRepository.IsPasswordAvailable(loginModel.Password, loginModel.Email);
                //    if (user != null)
                //    {
                //        if (user.Status != false && user.DeletedAt == null)
                //        {
                //            HttpContext.Session.SetString("useremail", loginModel.Email);
                //            var fullName = $"{user.FirstName} {user.LastName}";
                //            var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, fullName), new Claim(ClaimTypes.Role, user.Role) }, CookieAuthenticationDefaults.AuthenticationScheme);
                //            var principle = new ClaimsPrincipal(identity);
                //            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principle);
                //            Response.Cookies.Append("FullName", fullName);

                //            if (string.IsNullOrEmpty(user.Avatar))
                //            {
                //                HttpContext.Session.SetString("Avtar", "/Assets/404-Page-image.png");
                //            }
                //            else
                //            {
                //                HttpContext.Session.SetString("Avtar", user.Avatar);
                //            }
                //            if (user.Role == "Volunteer")
                //            {
                //                if (user.CountryId == null && user.CityId == null)
                //                {
                //                    return RedirectToAction("UserEditProfile", "User");
                //                }
                //                return RedirectToAction("Home", "Account");
                //            }

                //            else if (user.Role == "Admin")
                //            {
                //                return RedirectToAction("Admin_user", "Admin");
                //            }
                //        }
                //        else
                //        {
                //            ModelState.AddModelError("Email", "User Not Exist");
                //            return View("Login");
                //        }

                //    }
                //    else
                //    {
                //        ModelState.AddModelError("Password", "Enter correct password");
                //        return View("Login");
                //    }



                //}
                //else
                //{
                //    ModelState.AddModelError("email", "Enter correct email");
                //    return View("Login");
                //}

            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}