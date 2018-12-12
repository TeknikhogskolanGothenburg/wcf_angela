using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRentalWebClient
{
    public partial class CarViewAllWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarRentalService.CarRentalServiceClient client = new CarRentalService.CarRentalServiceClient("WSHttpBinding_ICarRentalService");
                List<CarRentalService.Car> cars = client.GetCars().ToList();

                rptCars.DataSource = cars;
                rptCars.DataBind();
            }
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeWebForm.aspx");
        }
    }
}