using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace CarRentalWebClient
{
    public partial class CustomerUpdateWebForm : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void customerSearchByHttpBtn_Click(object sender, EventArgs e)
        {
            CarRentalService.ICustomerService client = new CarRentalService.CustomerServiceClient("WSHttpBinding_ICustomerService");
            CarRentalService.CustomerRequest request = new CarRentalService.CustomerRequest();
            request.LicenseKey = "secret";
            request.CustomerId = Convert.ToInt32(customerIdTxt.Text);
            CarRentalService.CustomerInfo customer = null;
            try
            {
                customer = client.GetCustomer(request);
                txtFirstName.Text = customer.FirstName;
                txtLastName.Text = customer.LastName;
                txtMobile.Text = customer.Mobile;
                txtEmail.Text = customer.Email;
                customerTypeDropDownList.SelectedValue = ((int)customer.CustomerType).ToString();
                if (customer.CustomerType == CarRentalService.CustomerType.ContractCustomer)
                {
                    txtDiscount.Text = customer.Discount.ToString();
                    trdiscount.Visible = true;

                }
                else
                {
                    txtDiscount.Visible = false;
                }
                lblMessageUpdateCustomer.Text = "Customer Found";
            }
            catch (Exception ex)
            {
                lblMessageUpdateCustomer.Text = "Customer Not Found";
                client = new CarRentalService.CustomerServiceClient("WSHttpBinding_ICustomerService");
                customer = null;
            }
        }

        protected void customerSearchByTCPBtn_Click(object sender, EventArgs e)
        {
            CarRentalService.ICustomerService client = new CarRentalService.CustomerServiceClient("netTcpBinding_ICustomerService");
            CarRentalService.CustomerRequest request = new CarRentalService.CustomerRequest();
            request.LicenseKey = "secret";
            request.CustomerId = Convert.ToInt32(customerIdTxt.Text);
            CarRentalService.CustomerInfo customer = client.GetCustomer(request);
            //txtcustomerId.Text = customer.Id.ToString();
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtMobile.Text = customer.Mobile;
            txtEmail.Text = customer.Email;
            customerTypeDropDownList.SelectedValue = ((int)customer.CustomerType).ToString();
            if (customer.CustomerType == CarRentalService.CustomerType.ContractCustomer)
            {
                txtDiscount.Text = customer.Discount.ToString();
                trdiscount.Visible = true;

            }
            else
            {
                txtDiscount.Visible = false;
            }
            lblMessageUpdateCustomer.Text = "Customer Found";
        }

        protected void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            CarRentalService.ICustomerService client = new CarRentalService.CustomerServiceClient("WSHttpBinding_ICustomerService");

            CarRentalService.CustomerInfo customer = new CarRentalService.CustomerInfo();

           
            if (customerTypeDropDownList.SelectedValue == "-1")
            {
                lblMessageUpdateCustomer.Text = "Please select Employee Type";
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
            customer.Id = Convert.ToInt32(customerIdTxt.Text);
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.Mobile = txtMobile.Text;
            customer.Email = txtEmail.Text;


            client.UpdateCustomer(customer);


            lblMessageUpdateCustomer.Text = "Customer updated";


        }

        protected void btnBackToHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerViewAllWebForm.aspx");
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
                txtDiscount.Visible = true;
            }
        }

      
    }
}