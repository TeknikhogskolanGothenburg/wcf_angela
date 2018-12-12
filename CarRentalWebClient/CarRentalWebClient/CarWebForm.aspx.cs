using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRentalWebClient
{
    public partial class CaWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            
        }

       
        protected void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("CarAddWebForm.aspx");
        }

        protected void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("CarRemoveWebForm.aspx");
        }

        protected void btnViewAllCustomers_Click(object sender, EventArgs e)
        {
            Response.Redirect("CarViewAllWebForm.aspx");
        }
    }
}