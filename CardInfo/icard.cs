using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace CardInfo
{
    [ServiceContract]
    public interface icard
    {
        [OperationContract]
        [FaultContract(typeof(ArgumentException))]
        bool cardvalidate(int cardno);
        [OperationContract]
        [FaultContract(typeof(ArgumentException))]
        bool expValidate(DateTime transactdate);
        [OperationContract]
        [FaultContract(typeof(ArgumentException))]
        bool cvvValidate(int cvv);
        [OperationContract]
        [FaultContract(typeof(ArgumentException))]
        int transaction(double transactamt);
    }
}
