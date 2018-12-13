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
    public interface IBookingService
    {
        [OperationContract]
        [WebGet(UriTemplate = "Bookings",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        List<Booking> GetAllBookings();

        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "Bookings",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        Booking SaveBooking(Booking newBooking);

    }
}
