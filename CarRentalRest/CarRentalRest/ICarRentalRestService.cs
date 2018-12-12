using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CarRentalRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarRentalRestService" in both code and config file together.
    [ServiceContract]
    public interface ICarRentalRestService
    {
        [OperationContract]
        [WebGet(UriTemplate = "Cars",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<Car> GetAllCars();

        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "Cars",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        Car AddCar(Car newCar);


        [OperationContract]
        [WebGet(UriTemplate = "Customers",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<Customer> GetAllCustomers();

        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "Customers",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        Customer AddCustomer(Customer newCustomer);


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
        Booking AddBooking(Booking newBooking);

    }
}
