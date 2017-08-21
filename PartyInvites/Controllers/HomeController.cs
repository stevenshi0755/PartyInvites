using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ViewResult Index()  //从一个动作方法Index返回一个ViewResult对象
        //{
        //    return View();
        //    //return "hello world";

        //}
        
        //public RedirectResult Index()
        //{
        //    return Redirect("http://www.qq.com");
        //    //return ;
        //}

        //2.3.2
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good afternoon";
            ViewBag.t1 = DateTime.Now;
            return View();
            
        }
        public ActionResult T2()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            //todo:对晚会组织者发送email响应
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
            
        }
    }
}