using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalService
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        CustomerInfo GetCustomer(CustomerRequest request);

        [OperationContract]
        List<Customer> GetCustomers();

        [OperationContract]
        void SaveCustomer(CustomerInfo customer);

        [OperationContract]
        void UpdateCustomer(CustomerInfo customer);

        [OperationContract]
        void DeleteCustomer(CustomerRequest request);
    }
}
