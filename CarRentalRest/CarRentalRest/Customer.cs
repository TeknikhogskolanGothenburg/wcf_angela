using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalRest
{

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
