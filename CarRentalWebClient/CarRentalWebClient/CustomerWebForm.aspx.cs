using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRentalWebClient
{
    public partial class CustomerWebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerAddWebForm.aspx");
        }

        protected void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerRemoveWebForm.aspx");
        }

        protected void btnViewAllCustomers_Click(object sender, EventArgs e)
        {

            Response.Redirect("CustomerViewAllWebForm.aspx");

        }

        protected void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerUpdateWebForm.aspx");
        }
    }
}