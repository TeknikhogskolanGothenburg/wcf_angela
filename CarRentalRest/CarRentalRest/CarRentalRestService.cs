using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarRentalRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarRentalRestService" in both code and config file together.
    public class CarRentalRestService : ICarRentalRestService
    {
        private List<Car> cars;
        private List<Customer> customers;
        private List<Booking> bookings;

        public CarRentalRestService()
        {
            cars = new List<Car>
            {
               new Car
               {
                   Id=1,
                   RegisterNumber="ABC123",
                   Brand="BMW",
                   Model="X3",
                   DayRent=500,
                   Year=2014,
                   Status="available"
               }
            };

            customers = new List<Customer>
            {
                new Customer
                {
                    Id=1,
                    FirstName="Mark",
                    LastName="Andersson",
                    Mobile="0723654419",
                    Email="markander89@gmail.com",
                    CustomerType= CustomerType.PayAsGoCustomer
                }
            };

            bookings = new List<Booking>
            {
                new Booking
                {
                    Id=1,
                    StartTime= new DateTime(2015,5,10),
                    ReturnTime=new DateTime(2015,5,16),
                    CustomerId = 1,
                    CarId = 1
                }
            };
        }

        public Car AddCar(Car newCar)
        {
            cars.Add(newCar);
            return newCar;
        }

        public List<Car> GetAllCars()
        {
            return cars;
        }

        public Car EditCar(Car car, int index)
        {
            var editedCar = cars.SingleOrDefault(c => c.Id == index);
            editedCar.RegisterNumber = car.RegisterNumber;
            editedCar.Brand = car.Brand;
            editedCar.Model = car.Model;
            editedCar.Year = car.Year;
            editedCar.DayRent = car.DayRent;
            editedCar.Status = car.Status;
            return editedCar;
        }

        public void RemoveCar(Car car)
        {
            cars.Remove(car);
        }

        public Customer AddCustomer(Customer newCustomer)
        {
            customers.Add(newCustomer);
            return newCustomer;
        }

        public Customer EditCustomer(Customer customer, int index)
        {
            var editedCustomer = customers.SingleOrDefault(c => c.Id == index);
            editedCustomer.FirstName = customer.FirstName;
            editedCustomer.LastName = customer.LastName;
            editedCustomer.Email = customer.Email;
            editedCustomer.Mobile = customer.Mobile;
            editedCustomer.CustomerType = customer.CustomerType;
            return editedCustomer;
        }

        public List<Customer> GetAllCustomers()
        {
            return customers;
        }

        public void RemoveCustomer(Customer customer)
        {
            customers.Remove(customer);
        }

        public Booking AddBooking(Booking newBooking)
        {
            bookings.Add(newBooking);
            return newBooking;
        }


        public List<Booking> GetAllBookings()
        {
            return bookings;
        }

        public void RemoveBooking(Booking booking)
        {
            bookings.Remove(booking);
        }
















    }
}
