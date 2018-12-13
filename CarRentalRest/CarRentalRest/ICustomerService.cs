using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalRest
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        [WebGet(UriTemplate = "Customer/id",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        Customer GetCustomer(Customer newCustomer);

        [OperationContract]
        [WebGet(UriTemplate = "Customers",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<Customer> GetCustomers();

        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "SaveCustomer",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        void SaveCustomer(Customer newCustomer);

        [OperationContract]
        [WebInvoke(Method = "UPDATE",
           UriTemplate = "UpdateCustomer/id",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Wrapped)]
        void UpdateCarStatus(Customer customer, int id);

        [OperationContract]
        [WebInvoke(Method = "DELETE",
            UriTemplate = "Customer/id",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        void DeleteCustomer(Customer customer);



    }
}
