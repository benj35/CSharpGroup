using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpGroup.Models;
using CSharpGroup.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace CSharpGroup.Pages.Forms
{
    public class RegisterModel : PageModel
    {
        public int providerId = 0;
        public IList<User> userList;
        private readonly CSharpGroupContext _mycontext;

        public User user{ get; set; }
        public RegisterModel(CSharpGroupContext context)    
        {
            _mycontext = context;
        }
        public  void OnGet(int providerId)
        {
            //    userList = await _mycontext.Users.ToListAsync();
            this.providerId = providerId;
        }

    public IActionResult OnPost(User user, int providerId)  
        {

            if (ModelState.IsValid)
            {
               
             
                if (_mycontext.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("email", "Email already exists. Please login");
                    return Page();
                }

                if (user.Image == null)
                {
                    user.Image = "./img/default.jpg";
                }
                else
                {
                    user.Image = "./img/" + user.Image;
                }


                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                user.Role = "user";

               
                _mycontext.Add(user);
                _mycontext.SaveChanges();


                HttpContext.Session.SetString("role", user.Role);
                HttpContext.Session.SetString("email", user.Email);
                


                if (providerId == 0)
                {
                    return RedirectToPage("/Index");
                }

                return RedirectToPage("/Single_Provider", new { id = providerId, pag = 1 });
            }
            return Page();

        }
    }
}

