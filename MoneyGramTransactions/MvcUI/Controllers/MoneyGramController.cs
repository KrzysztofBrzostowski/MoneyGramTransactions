using Model.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UiCommon;

namespace MvcUI.Controllers
{
    public class MoneyGramController : ControllerOperationsBase
    {
        //private DataController m_DataController;
        public MoneyGramController()
        {
            //this.m_DataController = new DataController(this);
        }

        // GET: MoneyGram
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveTransaction(string currency, int customerID, decimal amount)
        {
            //Jak rozróżnić rodzaje wyjątków i tym samym czy zapis do LogówSystemowych czy do LogówBusiness? 
            //Np po przez rózne typy wyjątkow, tj rozne klasy wywiedzione z Exception
            //i ich instancje utworzone przy zapisie do bazy np new BusinesException() lub new SystemException
            //try
            //{
              string transactionRes = this.m_DataController.SaveTransaction(currency, customerID, amount);
              if (transactionRes == string.Empty)
              {
                  return View();
              }
              else
              {
                  this.m_DataController.SaveError(new CustomErrorException(transactionRes));
                  return View("Error");              
              }
            //}
            //catch (Exception ex)// nie wiemy jakiego typu (rodzaju) jest wyjątek
                // wiec nie wiemy czy zapisac do logów biznesowych czy systemowych
            //{
               
                //this.m_DataController.SaveError(new CustomErrorException(ex));
                //return View("Error");
            //}

            //return Content((DateTime.Now.Millisecond % 2 == 0 ? 1 : 0).ToString());
        }
    }

    //public class MoneyGramController : Controller
    //{
    //    // GET: MoneyGram
    //    public ActionResult Index()
    //    {
    //        return View();
    //    }
    //}
}

