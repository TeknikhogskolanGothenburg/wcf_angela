using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalRest
{
    

    [DataContract]
    public class Booking
    {
        private int _id;
        private DateTime _startTime;
        private DateTime _returnTime;
        private int _customerId;
        private int _carId;
        private Customer _customer;
        private Car _car;


        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        [DataMember]
        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        [DataMember]
        public DateTime ReturnTime
        {
            get { return _returnTime; }
            set { _returnTime = value; }
        }

        [DataMember]
        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        [DataMember]
        public int CarId
        {
            get { return _carId; }
            set { _carId = value; }
        }


        [DataMember]
        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        [DataMember]
        public Car Car
        {
            get { return _car; }
            set { _car = value; }
        }



    }
}
