using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRentalWebClient
{
    public partial class CustomerViewAllWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack){
                CarRentalService.CarRentalServiceClient client = new CarRentalService.CarRentalServiceClient("WSHttpBinding_ICarRentalService");
                List<CarRentalService.Customer> customers = client.GetCustomers().ToList();
                var contractCustomers = customers.Where(c => Convert.ToInt32(c.CustomerType) == 2).ToList();
                rptCustomers.DataSource = contractCustomers;
                rptCustomers.DataBind();
            }
           
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeWebForm.aspx");
        }
    }
}