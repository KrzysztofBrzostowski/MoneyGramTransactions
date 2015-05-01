using DAL;
using Model.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServices
{

    // to jest BLL
    public class MoneyGramWebService : IMoneyGramWebService
    {
        public ICollection<Model.Currency> GetCurrencies()
        {
            using (var dal = new DalWrapper())
            {
                return dal.Currencies.ToList();
            }
        }

        public void SaveError(Model.Custom.CustomErrorException exception)
        {
            using (var dal = new DalWrapper())
            {
                var errorInfo = new Model.ErrorLog
                {
                    ErrorMessage = exception.ExceptionInfo,
                    DateCreated = DateTime.Now,
                    UserName = exception.UserName,
                    ComputerName = exception.ComputerName,
                    ProgramName = exception.ProgramName
                };

                dal.ErrorLogs.Add(errorInfo);
                dal.SaveChanges();
            }
        }

        public string SaveTransaction(string currencySymbol, string customerID, decimal amount)
        {
            string errorMessage = string.Empty;

            using (var dal = new DalWrapper())
            {
                using (var dbTran = dal.Database.BeginTransaction())
                {
                    try
                    {
                        // Krok 1. Znalezc klienta, a jesli nie ma to go dodac
                        // krok 2. znalezc walute, a jesli jej nie ma to albo blad albo ją dodac (raczej blad)
                        // krok 3. Majac ID waluty i klienta zapisac do tabeli transakcje

                        //MUSIMY UŻYĆ SINGLE OR DEFAULT
                        var cust = dal.Customers.SingleOrDefault(c => c.CustomerID.ToString().Equals(customerID));

                        //W aplikacji desktopowej moznaby uzyc System.Diagnostic.Debug.Assert ale TU NIE!!!

                        if (cust == null)
                        {
                            errorMessage = "Customer Name not found";
                        }
                        else
                        {
                            //Szukamy waluty
                            var currency = dal.Currencies.SingleOrDefault(c => c.Name == currencySymbol);

                            if (currency == null)
                            {
                                errorMessage = "Currency not found";
                            }
                            else//mamy wszystkie potrzebne dane 
                            {
                                var tranRecord = new Model.Transaction { Amount = amount, CurrencyID = currency.CurrencyID, CustomerID = cust.CustomerID, Date = DateTime.Now, Code = Guid.NewGuid().ToString() };
                                dal.Transactions.Add(tranRecord);
                                dal.SaveChanges();
                                dbTran.Commit();
                            }
                        }
                    }//try
                    catch(Exception e)
                    {
                        //IsSuccess = fasle;
                        dbTran.Rollback();
                        errorMessage = e.Message;
                    }

                    }//using

                }//1 using



                //Generalnie po tej stronie zapisujemy Log do bazy
                //dal.ErrorLogs.Add(errorInfo);

            //IsSuccess
            //Zapis do LOG

            //if (!string.IsNullOrEmpty(errorMessage))
            //{
            //    throw new Exception(errorMessage);
            //}            

            //return "0";

            return errorMessage;

        }
    }
}
