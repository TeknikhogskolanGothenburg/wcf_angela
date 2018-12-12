using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRentalWebClient
{
    public partial class CustomerRemoveWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            CarRentalService.ICarRentalService client = new CarRentalService.CarRentalServiceClient("WSHttpBinding_ICarRentalService");
            CarRentalService.CustomerRequest request = new CarRentalService.CustomerRequest();
            request.LicenseKey = "secret";
            request.CustomerId = Convert.ToInt32(deleteCustomerTxt.Text);
            client.DeleteCustomer(request);
            deleteMessage.Text = "Customer is deleted";
           
        }

        protected void btnBackToMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeWebForm.aspx");
        }
    }
}