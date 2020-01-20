using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VOD.UI.Models;
using Microsoft.AspNetCore.Identity;
using VOD.Common.Entities;
using VOD.Database.Services;
using VOD.Common.Extensions;
using VOD.UI.Services;

namespace VOD.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IDbReadService _db;
        //private readonly IUIReadService _db;

        public HomeController(ILogger<HomeController> logger, SignInManager<VODUser> signInMgr /*, IUIReadService db*/ /*, IDbReadService db*/)
        {
            _logger = logger;
            _signInManager = signInMgr;
            //_db = db;
        }

        public /*async Task<*/ IActionResult /*>*/ Index()
        {
            //var result1 = await _db.GetAsync<Download>();
            //var result2 = await _db.GetAsync<Download>(d => d.ModuleId.Equals(1));
            //var result3 = await _db.SingleAsync<Download>(d => d.Id.Equals(3));

            //var videos = new List<Video>();
            //var convertedVideos = videos.ToSelectList<Video>("Id", "Title");

            //_db.Include<Download>();
            //_db.Include<Module, Course>();
            //var result5 = await _db.SingleAsync<Download>(d => d.Id.Equals(3));
            //var result6 = await _db.SingleAsync<Download>(d => d.Id.Equals(3));

            //---------
            //var user = await _signInManager.UserManager.GetUserAsync(HttpContext.User);

            //if(user != null)
            //{
            //    var courses = await _db.GetCoursesAsync(user.Id);
            //    var course = await _db.GetCourseAsync(user.Id, 1);
            //    var videos = await _db.GetVideosAsync(user.Id, 1);
            //    var video = await _db.GetVideoAsync(user.Id, 1);
            //}

            if (!_signInManager.IsSignedIn(User))
            {
                return RedirectToPage("/Account/Login", new { Area = "Identity" });
            }
            return RedirectToAction("Dashboard", "Membership");
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

        private SignInManager<VODUser> _signInManager;
    }
}
