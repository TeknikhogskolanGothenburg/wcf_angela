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
       WrapperName = "BookingRequestObject", WrapperNamespace = "")]
    public class BookingRequest
    {
        [MessageHeader(Namespace = "")]
        public string LicenseKey { get; set; }

        [MessageBodyMember(Namespace = "")]
        public int BookingId { get; set; }
    }


    [MessageContract(IsWrapped = true,
        WrapperName = "BookingInfoObject", WrapperNamespace = "")]
    public class BookingInfo
    {
        public BookingInfo() { }

        public BookingInfo(Booking booking)
        {
            this.Id = booking.Id;
            this.StartTime = booking.StartTime;
            this.ReturnTime = booking.ReturnTime;
            this.CustomerId = booking.CustomerId;
            this.CarId = booking.CarId;
        }

        [MessageBodyMember(Order = 1, Namespace = "")]
        public int Id { get; set; }

        [MessageBodyMember(Order = 2, Namespace = "")]
        public DateTime StartTime { get; set; }

        [MessageBodyMember(Order = 3, Namespace = "")]
        public DateTime ReturnTime { get; set; }

        [MessageBodyMember(Order = 4, Namespace = "")]
        public int CustomerId { get; set; }

        [MessageBodyMember(Order = 5, Namespace = "")]
        public int CarId { get; set; }

        [MessageBodyMember(Order = 6, Namespace = "")]
        public Customer Customer { get; set; }

        [MessageBodyMember(Order = 7, Namespace = "")]
        public Car Car { get; set; }
    }



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
