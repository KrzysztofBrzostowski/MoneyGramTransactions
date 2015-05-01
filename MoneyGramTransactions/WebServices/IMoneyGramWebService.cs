using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServices
{
    [ServiceContract]
    public interface IMoneyGramWebService
    {
        [OperationContract]
        ICollection<Model.Currency> GetCurrencies();

        [OperationContract]
        string SaveTransaction(string currencySymbol, string customerName, decimal amount);

        [OperationContract]
        void SaveError(Model.Custom.CustomErrorException exception);
    }
}
