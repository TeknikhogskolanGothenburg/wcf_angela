using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRentalWebClient
{
    public partial class CustomerAddWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBackToHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeWebForm.aspx");
        }

        protected void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            CarRentalService.ICustomerService client = new CarRentalService.CustomerServiceClient("WSHttpBinding_ICustomerService");
            CarRentalService.CustomerInfo customer = new CarRentalService.CustomerInfo();
            if (customerTypeDropDownList.SelectedValue == "-1")
            {
                lblMessageCustomer.Text = "Please select Employee Type";
            }
            else if (((CarRentalService.CustomerType)Convert.ToInt32(customerTypeDropDownList.SelectedValue))
                    == CarRentalService.CustomerType.PayAsGoCustomer)
            {
                customer.CustomerType = CarRentalService.CustomerType.PayAsGoCustomer;
            }
            else
            {

                customer.CustomerType = CarRentalService.CustomerType.ContractCustomer;
                customer.Discount = Convert.ToDecimal(txtDiscount.Text);

            }
            customer.Id = Convert.ToInt32(txtCustomerId.Text);
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.Mobile = txtMobile.Text;
            customer.Email = txtEmail.Text;



                client.SaveCustomer(customer);

                lblMessageCustomer.Text = "Customer saved";
            }
        

        protected void customerTypeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerTypeDropDownList.SelectedValue == "-1")
            {
                trdiscount.Visible = false;
            }
            else if (customerTypeDropDownList.SelectedValue == "1")
            {
                trdiscount.Visible = false;
            }
            else
            {
                trdiscount.Visible = true;
            }

        }
    }
}