using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfInterfaces
{
    [ServiceContract]
    public interface IMoneyGramWebService
    {
        [OperationContract]
        ICollection<Model.Currency> GetCurrencies();

        [OperationContract]
        string SaveTransaction(Model.Currency currency, Model.Customer customer, decimal amount);
    }
}
