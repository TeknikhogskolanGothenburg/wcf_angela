using CarRentalRest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarRentalRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarRentalRestService" in both code and config file together.
    public class CarRentalRestService : ICarRentalRestService,IBookingService,ICustomerService
    {
       
        DataContext dataContext = new DataContext();

        public Car GetCar(Car newCar)
        {
           return dataContext.GetCar(newCar);
        }

        public void SaveCar(Car newCar)
        {
            dataContext.SaveCar(newCar);
            
           
        }

        public List<Car> GetCars()
        {
            return dataContext.GetCars();
        }

        public void UpdateCarStatus(Car car)
        {
            var editedCar = dataContext.GetCars().SingleOrDefault(c => c.Id == car.Id);
            editedCar.RegisterNumber = car.RegisterNumber;
            editedCar.Brand = car.Brand;
            editedCar.Model = car.Model;
            editedCar.Year = car.Year;
            editedCar.DayRent = car.DayRent;
            editedCar.Status = car.Status;
        }

        public void DeleteCar(Car car)
        {
            dataContext.GetCars().Remove(car);
        }

        public Customer GetCustomer(Customer newCustomer)
        {
            return dataContext.GetCustomer(newCustomer);
        }

        public List<Customer> GetCustomers()
        {
            return dataContext.GetCustomers();
        }


        public void SaveCustomer(Customer newCustomer)
        {
            dataContext.GetCustomers().Add(newCustomer);

        }

        public void UpdateCustomer(Customer customer,int id)
        {
            var editedCustomer = dataContext.GetCustomers().SingleOrDefault(c => c.Id == id);
            editedCustomer.FirstName = customer.FirstName;
            editedCustomer.LastName = customer.LastName;
            editedCustomer.Email = customer.Email;
            editedCustomer.Mobile = customer.Mobile;
            editedCustomer.CustomerType = customer.CustomerType;
        }

       
        public void DeleteCustomer(Customer customer)
        {
            dataContext.GetCustomers().Remove(customer);
        }

        public Booking GetBooking(Booking newBooking)
        {
            return dataContext.GetBooking(newBooking);
        }

        public Booking SaveBooking(Booking newBooking)
        {
            dataContext.GetBookings().Add(newBooking);
            return newBooking;
        }


        public List<Booking> GetAllBookings()
        {
            return dataContext.GetBookings();
        }

        public void RemoveBooking(Booking booking)
        {
            dataContext.GetBookings().Remove(booking);
        }

        public void UpdateCarStatus(Customer customer, int id)
        {
            throw new NotImplementedException();
        }
    }
}
