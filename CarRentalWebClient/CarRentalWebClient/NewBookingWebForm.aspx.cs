using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRentalWebClient
{
    public partial class BookingWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarRentalService.CarRentalServiceClient client = new CarRentalService.CarRentalServiceClient("WSHttpBinding_ICarRentalService");
                List<CarRentalService.Car> cars = client.GetCars().ToList();
                List<CarRentalService.Customer> customers = client.GetCustomers().ToList();
             

                List<String> carDropDownList = new List<string>();
                List<String> customerDropDownList = new List<string>();

                foreach (var car in cars)
                {
                    string carItem = String.Format("{0} {1}, Year {2}", car.Brand, car.Model, car.Year);
                    carDropDownList.Add(carItem);
                }

                foreach (var customer in customers)
                {
                    string customerItem = String.Format("{0} {1}", customer.FirstName, customer.LastName);
                    customerDropDownList.Add(customerItem);
                }

                carList.DataSource = carDropDownList;
                carList.DataBind();


                customerList.DataSource = customerDropDownList;
                customerList.DataBind();

                startCalenda.Visible = false;
                endCalenda.Visible = false;
            }
           

        }

        protected void bookBtn_Click(object sender, EventArgs e)
        {
            CarRentalService.ICarRentalService client = new CarRentalService.CarRentalServiceClient("WSHttpBinding_ICarRentalService");
            
            CarRentalService.BookingInfo booking = new CarRentalService.BookingInfo();
            CarRentalService.CarInfo car = new CarRentalService.CarInfo();
            booking.Id = Convert.ToInt32(txtBooking.Text);
            booking.CarId = carList.SelectedIndex+1;
            booking.CustomerId = customerList.SelectedIndex +1;
            booking.StartTime = startCalenda.SelectedDate;
            booking.ReturnTime = endCalenda.SelectedDate;

            car.Id = booking.CarId;
            car.Status = "rented";
        

            client.SaveBooking(booking);
            client.UpdateCarStatus(car);

            lblMessageBooking.Text = "Booking saved";


        }

        protected void newCustomerBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerAddWebForm.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if(startCalenda.Visible)
            {
                startCalenda.Visible = false;
            }
            else
            {
                startCalenda.Visible = true;
            }
           
            
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if (endCalenda.Visible)
            {
                endCalenda.Visible = false;
            }
            else
            {
                endCalenda.Visible = true;
            }
        }

        protected void startCalenda_SelectionChanged(object sender, EventArgs e)
        {
            txtStartDate.Text = startCalenda.SelectedDate.ToLongDateString();

        }

        protected void endCalenda_SelectionChanged(object sender, EventArgs e)
        {
            txtEndDate.Text = endCalenda.SelectedDate.ToLongDateString();
        }
    }
}