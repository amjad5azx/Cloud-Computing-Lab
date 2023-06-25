using FeeWorkFlow;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkFlow_Task2.Models;


namespace WorkFlow_Task2.Controllers
{
    public class FeeChalanController : Controller
    {
        // GET: FeeChalan
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GenerateChalan(FeeChalan model)
        {
            int classGrade = int.Parse(model.ClassGrade);
            string category = model.Category;
            Workflow1 workflow = new Workflow1();
            workflow.ClassGrade = int.Parse(model.ClassGrade);
            workflow.Category = model.Category;
            IDictionary<string, object> result = WorkflowInvoker.Invoke(workflow);
            double fees = (double)result["Fees"];
            model.Fees = fees;
            return View(model);
        }
    }
}