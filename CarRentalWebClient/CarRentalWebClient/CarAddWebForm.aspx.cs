using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRentalWebClient
{
    public partial class CarAddWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNewCar_Click(object sender, EventArgs e)
        {
            CarRentalService.ICarRentalService client = new CarRentalService.CarRentalServiceClient("WSHttpBinding_ICarRentalService");

            CarRentalService.CarInfo car = new CarRentalService.CarInfo();
            car.Id = Convert.ToInt32(txtCarId.Text);
            car.RegisterNumber = txtRegisterNumber.Text;
            car.Brand = txtBrand.Text;
            car.Model = txtModel.Text;
            car.DayRent = Convert.ToInt32(txtDayRent.Text);
            car.Year = Convert.ToInt32(txtYear.Text);
            car.Status = txtStatus.Text;

            //CarRentalService.CarRentalServiceClient client = new CarRentalService.CarRentalServiceClient();

            client.SaveCar(car);

            lblMessageCar.Text = "Car saved";
        }

        protected void btnBackToHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeWebForm.aspx");
        }
    }
}