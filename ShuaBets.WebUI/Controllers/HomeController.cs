using ShuaBets.Domain.Context;
using ShuaBets.Domain.Entities;
using ShuaBets.Domain.Enums;
using ShuaBets.WebUI.Infrastructure.Helpers;
using ShuaBets.WebUI.Models.Adverts;
using ShuaBets.WebUI.Models.Dashboard;
using ShuaBets.WebUI.Models.Exclusive;
using ShuaBets.WebUI.Models.Free;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShuaBets.WebUI.Controllers
{
    public class HomeController : BaseController
    {


        public ActionResult Index(SearchFreeViewModel search, int page = 1)
        {
            // Return all Tips
            // If not a post-back (i.e. initial load) set the searchModel to session
            if (Request.Form.Count <= 0)
            {
                if (search.IsEmpty() && Session["SearchFreeViewModel"] != null)
                {
                    search = (SearchFreeViewModel)Session["SearchFreeViewModel"];
                }
            }

            var helper = new FreeTipHelper();
            var model = helper.GetTipList(search, search.ParsePage(page));

            Session["SearchFreeViewModel"] = search;

            //(search);

            return View(model);
        }


        public ActionResult About()
        {
            return View();

        }

        public ActionResult Services()
        {
          
            return View();
        }

        [HttpGet]
        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        public PartialViewResult GetTipStats()
        {

            var model = new TipStatsModel
            {
                TotalExclisuve = context.ExclusiveTips.ToList().Count(),
                TotalFree = context.FreeTips.ToList().Count(),
                ExclPending = context.ExclusiveTips.ToList().Where(p => p.Status == Status.Pending).Count(),
                ExclCorrect = context.ExclusiveTips.ToList().Where(p => p.Status == Status.Correct).Count(),
                ExclWrong = context.ExclusiveTips.ToList().Where(p => p.Status == Status.Wrong).Count(),
                FreePending = context.FreeTips.ToList().Where(p => p.Status == Status.Pending).Count(),
                FreeCorrect = context.FreeTips.ToList().Where(p => p.Status == Status.Correct).Count(),
                FreeWrong = context.FreeTips.ToList().Where(p => p.Status == Status.Wrong).Count(),

            };

            return PartialView("Dashboard/_HomeStats", model);
        }

        public PartialViewResult GetMatches(SearchExclusiveViewModel search, int page = 1)
        {

            if (Request.Form.Count <= 0)
            {
                if (search.IsEmpty() && Session["SearchExclusiveViewModel"] != null)
                {
                    search = (SearchExclusiveViewModel)Session["SearchExclusiveViewModel"];
                }
            }

            var helper = new ExclusiveTipHelper();
            var model = helper.GetTipList(search, search.ParsePage(page));

            return PartialView("Dashboard/_GamesPlayedSlider", model);
        }



        public PartialViewResult GetAds()
        {
            var model = new AdListViewModel
            {
                Adverts = context.Adverts.ToList()
            };

            return PartialView("Partials/_Ads", model);
        }


        //public ActionResult Quotation()
        //{

        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Quotation(QuoteRequestViewModel q)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        using (context)
        //        {
        //            var quote = q.ParseAsEntity(new QuoteRequest());
        //            context.QuoteRequests.Add(quote);
        //            context.SaveChanges();

        //            // send email
        //            var mail = GetMailHelper();
        //            string subject = string.Format("{0} - Quote request", quote.Name);
        //            string message = QuotationNotificationMsg(quote);
        //            string status = string.Join(":", mail.SendMail(subject, message, ConfigurationManager.AppSettings["Settings.Company.Email"]));
        //            mail.RecordErrors();

        //            return RedirectToAction("Thanks");
        //        }

        //    }

        //    return View();
        //}

        //public ActionResult Support()
        //{

        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Support(SupportRequestViewModel s)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        using (context)
        //        {
        //            var support = s.ParseAsEntity(new SupportRequest());
        //            context.SupportRequests.Add(support);
        //            context.SaveChanges();

        //            // send email
        //            var mail = GetMailHelper();
        //            string subject = string.Format("{0} - Support request", support.Name);
        //            string message = SupportNotificationMsg(support);
        //            string status = string.Join(":", mail.SendMail(subject, message, ConfigurationManager.AppSettings["Settings.Company.Email"]));
        //            mail.RecordErrors();

        //            return RedirectToAction("Thanks");
        //        }

        //    }

        //    return View();
        //}

        public ActionResult AdminPage()
        {

            return RedirectToAction("Index", "HomeAdmin");
        }

        public ActionResult Thanks()
        {
            return View();
        }

        public MailHelper GetMailHelper()
        {
            MailHelper mail = new MailHelper(null);
            mail.UserId = null;

            return mail;
        }

    }
}