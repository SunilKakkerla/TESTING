using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Business;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        #region DbContext
        private readonly AppDbContext appContext;
        public EmployeeController(AppDbContext context)
        {
            appContext = context;
        }
        [HttpGet]
        public IEnumerable<ApplicantModel> GetApplicant()
        {
            return appContext.ApplicantModel;
        }

        #endregion 

        #region Applicant

        public ActionResult AddApplicant(Applicant app)
        {
            Business.Model model = new Business.Model();
            Business.ApplicantModel app1 = model.ConvertToApplicantModel(app);
            //Added first Changes to the Version Control
            using (appContext)
            {         

                appContext.ApplicantModel.Add(app1);
                IEnumerable<ApplicantModel> aone =GetApplicant();
                appContext.SaveChangesAsync();

            }
            return Content("Applicant has successfully been added ");
        }
        public ActionResult ChangeApplicantDetails(Applicant app)
        {
            using (appContext)
            {
                //appContext.Applicant.Update(app);
                appContext.SaveChangesAsync();
            }

            return View();
        }
        public ActionResult DeleteAccount(Applicant app)
        {
            using (appContext)
            {
                //appContext.Applicant.Remove(app);
                appContext.SaveChanges();
            }

            return View();
        }
        #endregion

        #region Transaction
        public ActionResult AddAmount(Transaction tran)
        {
            using (appContext)
            {
                appContext.Transaction.Add(tran);
                appContext.SaveChangesAsync();
            }
            return View();
        }
        public ActionResult DeductAmount(Transaction deduct)
        {
            using (appContext)
            {
                appContext.Transaction.Add(deduct);
                appContext.SaveChangesAsync();
            }
            return View();
        }
        public ActionResult Transfer(Transaction trans)
        {
            using (appContext)
            {
                appContext.Transaction.Add(trans);
                appContext.SaveChangesAsync();
            }
            return View();
        }
        #endregion

    }
}