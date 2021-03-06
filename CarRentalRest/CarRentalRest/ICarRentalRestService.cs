﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CarRentalRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarRentalRestService" in both code and config file together.
    [ServiceContract]
    public interface ICarRentalRestService
    {
        [OperationContract]
        [WebGet(UriTemplate = "Car/id",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        Car GetCar(Car car);

        [OperationContract]
        [WebGet(UriTemplate = "Cars",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<Car> GetCars();

        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "SaveCar",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        void SaveCar(Car car);

        [OperationContract]
        [WebInvoke(Method = "UPDATE",
            UriTemplate = "UpdateCar",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        void UpdateCarStatus(Car car);

        [OperationContract]
        [WebInvoke(Method = "DELETE",
            UriTemplate = "Delete",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        void DeleteCar(Car car);

    }
}
