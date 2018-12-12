﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarRentalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarRentalService" in both code and config file together.
    [ServiceContract]
    public interface ICarRentalService
    {
        [OperationContract]
        CarInfo GetCar(CarRequest request);

        [OperationContract]
        List<Car> GetCars();

        [OperationContract]
        void SaveCar(CarInfo car);

        [OperationContract]
        void UpdateCarStatus(CarInfo car);

        [OperationContract]
        void DeleteCar(CarRequest request);

        [OperationContract]
        CustomerInfo GetCustomer(CustomerRequest request);

        [OperationContract]
        List<Customer> GetCustomers();

        [OperationContract]
        void SaveCustomer(CustomerInfo customer);

        [OperationContract]
        void UpdateCustomer(CustomerInfo customer);


        [OperationContract]
        void DeleteCustomer(CustomerRequest request);

        [OperationContract]
        BookingInfo GetBooking(BookingRequest request);

        [OperationContract]
        void SaveBooking(BookingInfo booking);

        [OperationContract]
        void DeleteBooking(BookingRequest request);
    }

}
