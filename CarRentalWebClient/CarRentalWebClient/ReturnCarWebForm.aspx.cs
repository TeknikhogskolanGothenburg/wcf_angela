using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRentalWebClient
{
    public partial class ReturnCarWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchingBookingBtn_Click(object sender, EventArgs e)
        {
            CarRentalService.ICarRentalService client = new CarRentalService.CarRentalServiceClient("WSHttpBinding_ICarRentalService");
            CarRentalService.IBookingService client1 = new CarRentalService.BookingServiceClient("WSHttpBinding_IBookingService");
            CarRentalService.ICustomerService client2 = new CarRentalService.CustomerServiceClient("WSHttpBinding_ICustomerService");

            CarRentalService.BookingRequest request = new CarRentalService.BookingRequest();
            CarRentalService.CustomerRequest customerRequest = new CarRentalService.CustomerRequest();
            CarRentalService.CarRequest carRequest = new CarRentalService.CarRequest();
            request.LicenseKey = "secret";
            request.BookingId = Convert.ToInt32(txtReturningCar.Text);
            
            CarRentalService.BookingInfo booking = client1.GetBooking(request);
            customerRequest.LicenseKey = "secret";
            customerRequest.CustomerId = booking.CustomerId;

            carRequest.CarId = booking.CarId;
            carRequest.LicenseKey = "secret";

            CarRentalService.CustomerInfo customer = client2.GetCustomer(customerRequest);
            CarRentalService.CarInfo car = client.GetCar(carRequest);

            startTimeTxt.Text = booking.StartTime.ToString();
            returnTimeTxt.Text = booking.ReturnTime.ToString();
            
            customerFirstNameTxt.Text = customer.FirstName;
            customerLastNameTxt.Text = customer.LastName;
            customerEmailTxt.Text = customer.Email;

            carRegisterNumberTxt.Text = car.RegisterNumber;
            carBrandTxt.Text = car.Brand;
            carModelTxt.Text = car.Model;
            carYearTxt.Text = car.Year.ToString();
            carDayRentTxt.Text =car.DayRent.ToString();
            lblMessageReturning.Text = "Booking found";
            
        }


        protected void btnReturningCar_Click(object sender, EventArgs e)
        {
            CarRentalService.IBookingService client = new CarRentalService.BookingServiceClient("WSHttpBinding_IBookingService");
            CarRentalService.ICarRentalService client1 = new CarRentalService.CarRentalServiceClient("WSHttpBinding_ICarRentalService");
            CarRentalService.BookingRequest request = new CarRentalService.BookingRequest();

            CarRentalService.CarRequest carRequest = new CarRentalService.CarRequest();
            request.LicenseKey = "secret";
            request.BookingId = Convert.ToInt32(txtReturningCar.Text);

            CarRentalService.BookingInfo booking = client.GetBooking(request);


            carRequest.CarId = booking.CarId;
            carRequest.LicenseKey = "secret";
            CarRentalService.CarInfo car = new CarRentalService.CarInfo();


            car.Id = booking.CarId;
            car.Status = "available";
            client1.UpdateCarStatus(car);

            lblMessageReturning.Text = "Car Returned";
        }
    }
}