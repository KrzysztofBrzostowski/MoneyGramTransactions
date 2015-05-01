using Model.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace UiCommon
{
    /// <summary>
    /// Collector usług
    /// </summary>
    public class DataController
    {
        //public DataController(System.Web.Mvc.Controller controller)

        public DataController(object controllerOrPage)
        {
            if (controllerOrPage is System.Web.UI.Page)
            {
                WebFormHandlers((System.Web.UI.Page)controllerOrPage);
            }
        }

        public string SaveTransaction(string currency, int customerID, decimal amount)
        {
            if (amount < 1)
            {
                //powino byc przekierowanie i do logu
                throw new Exception("Bledna wartosc");
            }

            string SaveTransactionRes = string.Empty;
            //string SaveTransaction(string currencySymbol, string customerName, decimal amount)
            using (var service = new MoneyGramWebServiceClient.MoneyGramWebServiceClient())
            {                
                SaveTransactionRes = service.SaveTransaction(currency, customerID.ToString(), amount);
            }

            return SaveTransactionRes;
        }

        public System.Web.Mvc.ActionResult Contact()
        {
            return null;
        }

        void WebFormHandlers(System.Web.UI.Page page)
        {
            page.Load += (o, s) =>
            {
                var listCurrencies = (DropDownList)page.FindControl("listCurrencies");
                listCurrencies.DataSource = GetCurrencies();
                listCurrencies.DataTextField = "Name";
                listCurrencies.DataBind();
            };
        }

        Model.Currency[] GetCurrencies()
        {
            try
            {
                using (var service = new MoneyGramWebServiceClient.MoneyGramWebServiceClient())
                {
                    return service.GetCurrencies();
                }
            }
            catch (Exception ex)
            {
                //wcf.SaveException(new CustomErrorException(ex));
            }

            return null;
        }

        public void SaveError(Model.Custom.CustomErrorException exception)
        {
            using (var service = new MoneyGramWebServiceClient.MoneyGramWebServiceClient())
            {
                service.SaveError(exception);
            }
        }
    }
}
