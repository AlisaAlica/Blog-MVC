using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Domain;
using Blog.Domain.Entities;
using Blog.Domain.Entities.Repositiry;

namespace Blog.WebUI.Controllers
{
	public class HomeController : Controller
	{
		//New blogContext
		BlogContext blogContext = new BlogContext("BlogContext");

		//Start Page. News
		public ActionResult Index()
		{
			return View(blogContext.Newses.ToList());
		}

		//Profile. Add new profile
		public ActionResult Profile()
		{
			return View();
		}

		// Save new profile and display all profiles. Post method
		[HttpPost]
		public ActionResult Info()
		{
			string firstName = Request.Form["Name"];
			string secondName = Request.Form["LastName"];
			string sex = Request.Form["sex"];
			string kross = Request.Form["Кросс"];
			string treck = Request.Form["Трек"];
			string street = Request.Form["Стрит"];
			string chopper = Request.Form["Чоппер"];
			string enduro = Request.Form["Эндуро"];
			string turing = Request.Form["Турист"];
			blogContext.AddProfile(firstName, secondName, sex, kross, treck, street, chopper, enduro, turing);
			return View(blogContext.Profiles.ToList());
		}

		// Save new profile and display all profiles. Get method
		[HttpGet]
		public ActionResult Info(string date)
		{
			string firstName = Request.Form["Name"];
			string secondName = Request.Form["LastName"];
			string sex = Request.Form["sex"];
			string kross = Request.Form["Кросс"];
			string treck = Request.Form["Трек"];
			string street = Request.Form["Стрит"];
			string chopper = Request.Form["Чоппер"];
			string enduro = Request.Form["Эндуро"];
			string turing = Request.Form["Турист"];

			blogContext.AddProfile(firstName, secondName, sex, kross, treck, street, chopper, enduro, turing);

			return View(blogContext.Profiles.ToList());
		}

		//Add new guest
		[HttpPost]
		public ActionResult AddGuest()
		{
			string name = Request.Form["Name"];
			string guestText = Request.Form["Text"];
			blogContext.AddGuest(name, guestText);
			return View("../Home/Guest", blogContext.Guests.ToList());
		}

		//Display all guests
		public ActionResult Guest()
		{
			return View(blogContext.Guests.ToList());
		}

	}
}