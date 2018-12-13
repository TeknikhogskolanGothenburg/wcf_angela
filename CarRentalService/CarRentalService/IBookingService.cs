using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalService
{
    [ServiceContract]
    public interface IBookingService
    {
        [OperationContract]
        BookingInfo GetBooking(BookingRequest request);

        [OperationContract]
        void SaveBooking(BookingInfo booking);

        [OperationContract]
        void DeleteBooking(BookingRequest request);

        [OperationContract]
        List<Booking> GetBookings();
    }
}
