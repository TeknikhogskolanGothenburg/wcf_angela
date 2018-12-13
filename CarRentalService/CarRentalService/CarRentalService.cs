using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.Net;
using CarRentalService.Data;

namespace CarRentalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarRentalService" in both code and config file together.
    //[ServiceBehavior(InstanceContextMode =InstanceContextMode.PerSession, ConcurrencyMode =ConcurrencyMode.Multiple)]
    public class CarRentalService : ICarRentalService, IBookingService, ICustomerService
    {
        DataContext dataContext = new DataContext();
        public void DeleteBooking(BookingRequest request)
        {
            dataContext.DeleteBooking(request);
        }

        public void DeleteCar(CarRequest request)
        {
            dataContext.DeleteCar(request);
        }

        public void DeleteCustomer(CustomerRequest request)
        {
            dataContext.DeleteCustomer(request);
        }

        public BookingInfo GetBooking(BookingRequest request)
        {
            return dataContext.GetBooking(request);
        }

        public List<Booking> GetBookings()
        {
            return dataContext.GetBookings();
        }

        public CarInfo GetCar(CarRequest request)
        {
           
            return dataContext.GetCar(request); 
        }

        public List<Car> GetCars()
        {
            return dataContext.GetCars();
        }

        public CustomerInfo GetCustomer(CustomerRequest request)
        {
            return dataContext.GetCustomer(request);
        }

        public List<Customer> GetCustomers()
        {
            return dataContext.GetCustomers();
        }

        public void SaveBooking(BookingInfo booking)
        {
                dataContext.SaveBooking(booking);
        }

        public void SaveCar(CarInfo car)
        {
            dataContext.SaveCar(car);
        }

        public void SaveCustomer(CustomerInfo customer)
        {
            dataContext.SaveCustomer(customer);
        }

        public void UpdateCarStatus(CarInfo car)
        {
            dataContext.UpdateCarStatus(car);
        }

        public void UpdateCustomer(CustomerInfo customer)
        {
            
        }
    }
}
