using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRentalWebClient
{
    public partial class DeleteBookingWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeleteBoooking_Click(object sender, EventArgs e)
        {
            CarRentalService.ICarRentalService client = new CarRentalService.CarRentalServiceClient("WSHttpBinding_ICarRentalService");
            CarRentalService.BookingRequest request = new CarRentalService.BookingRequest();
            request.LicenseKey = "secret";
            request.BookingId = Convert.ToInt32(txtDeleteBooking.Text);
            client.DeleteBooking(request);
            deleteMessage.Text = "Booking is deleted";
        }

        protected void btnBackToMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReturnOptionsWebForm.aspx");
        }
    }
}