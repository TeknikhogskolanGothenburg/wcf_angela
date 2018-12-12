using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalRest
{
    [MessageContract(IsWrapped = true,
        WrapperName = "CustomerRequestObject",
        WrapperNamespace = "")]
    public class CustomerRequest
    {
        [MessageHeader(Namespace = "")]
        public string LicenseKey { get; set; }

        [MessageBodyMember(Namespace = "")]
        public int CustomerId { get; set; }
    }


    [MessageContract(IsWrapped = true,
        WrapperName = "CustomerInfoObject",
        WrapperNamespace = "")]
    public class CustomerInfo
    {
        public CustomerInfo() { }

        public CustomerInfo(Customer customer)
        {
            this.Id = customer.Id;
            this.FirstName = customer.FirstName;
            this.LastName = customer.LastName;
            this.Mobile = customer.Mobile;
            this.Email = customer.Email;
            this.CustomerType = customer.CustomerType;
            if (this.CustomerType == CustomerType.ContractCustomer)
            {
                this.Discount = ((ContractCustomer)customer).Discount;
            }

        }

        [MessageBodyMember(Order = 1, Namespace = "")]
        public int Id { get; set; }

        [MessageBodyMember(Order = 2, Namespace = "")]
        public string FirstName { get; set; }

        [MessageBodyMember(Order = 3, Namespace = "")]
        public string LastName { get; set; }

        [MessageBodyMember(Order = 4, Namespace = "")]
        public string Mobile { get; set; }

        [MessageBodyMember(Order = 5, Namespace = "")]
        public string Email { get; set; }

        [MessageBodyMember(Order = 6, Namespace = "")]
        public CustomerType CustomerType { get; set; }

        [MessageBodyMember(Order = 7, Namespace = "")]
        public decimal Discount { get; set; }

    }




    [KnownType(typeof(PayAsGoCustomer))]
    [KnownType(typeof(ContractCustomer))]
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Mobile { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public CustomerType CustomerType { get; set; }
    }


    public enum CustomerType
    {
        PayAsGoCustomer = 1,
        ContractCustomer = 2
    }
}
