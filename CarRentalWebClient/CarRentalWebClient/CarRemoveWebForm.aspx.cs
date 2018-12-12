using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRentalWebClient
{
    public partial class CarRemoveWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeleteCar_Click(object sender, EventArgs e)
        {
            CarRentalService.ICarRentalService client = new CarRentalService.CarRentalServiceClient("WSHttpBinding_ICarRentalService");
            CarRentalService.CarRequest request = new CarRentalService.CarRequest();
            request.LicenseKey = "secret";
            request.CarId = Convert.ToInt32(deleteCarTxt.Text);
            client.DeleteCar(request);
            deleteCarMessage.Text = "Car is deleted";
        }

        protected void btnBackToMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeWebForm.aspx");
        }
    }
}