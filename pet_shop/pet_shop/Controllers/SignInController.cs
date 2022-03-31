using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using pet_shop.Models;
using pet_shop.MySQLRepository;
using pet_shop;

using static pet_shop.Globals;

namespace pet_shop.Controllers
{
    public class SignInController : Controller
    {
        // GET: SignInController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SignInController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SignInController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SignInController/Create
        [HttpPost]
        public ActionResult Check(IFormCollection collection)
        {
            try
            {
                string login = collection["login"];
                string password = collection["password"];
                Console.WriteLine($"login = {login}\npassword = {password}");
                /*
                Console.WriteLine("login:" + collection["login"]);
                Console.WriteLine("password:" + collection["password"]);
                Console.WriteLine("name:" + collection["name"]);
                Console.WriteLine("surname:" + collection["surname"]);*/

                
                var rep = new UserMySQLRepository();

                var user = rep.GetUserByLogin(login);
                if (user == null)
                {
                    ViewData["Message"] = "Пользователь не найден!";
                    return View("Index", "SignIn");
                }

                if (user.password != password)
                {
                    ViewData["Message"] = "Неправильный пароль!";
                    return View("Index", "SignIn");
                }

                Globals.user = user;

                /*CurrentUser.user.login = user.login;
                CurrentUser.user.password = user.password;
                CurrentUser.user.name = user.name;
                CurrentUser.user.surname = user.surname;
                CurrentUser.user.role = user.role;*/

                Console.WriteLine("Вы успешно авторизовались!");
                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: SignInController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SignInController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SignInController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SignInController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
