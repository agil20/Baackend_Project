using BakendProject.DAL;
using BakendProject.Helper;
using BakendProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BakendProject.Controllers
{
    public class EmailMessageController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private IConfiguration _config;

        public EmailMessageController(AppDbContext context, UserManager<AppUser> userManager, IConfiguration config = null)
        {
            _context = context;
            _userManager = userManager;
            _config = config;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Form([FromForm] Subscribe subs, string returnurl)
        {

            Subscribe subscribe = new Subscribe();
            List<Subscribe> subscribers = await _context.subscribes.ToListAsync();
            if (string.IsNullOrEmpty(subs.Email))
            {
                return Ok("Bos qoyma");
            }
            else
            {
                foreach (var item in subscribers)
                {
                    if (item.Email == subs.Email)
                    {
                        return Ok("You are already subscribed");
                    }
                    else
                    {
                        subscribe.Email = subs.Email;
                        var token = "";
                        string subject = "Subscription allup";
                        EmailHelper helper = new EmailHelper(_config.GetSection("ConfirmationParam:Email").Value, _config.GetSection("ConfirmationParam:Password").Value);

                        token = $"Thanks for subscribing to us. We will keep you informed so that you won't miss anything";
                        var emailResult = helper.SendNews(subs.Email, token, subject);
                        continue;

                        string confirmation = Url.Action("ConfirmEmail", "Account", new
                        {
                            token
                        }, Request.Scheme);
                        _context.subscribes.Add(subscribe);
                        _context.SaveChanges();
                    }
                }

                return Redirect(returnurl);
            }
        }
                }
}
