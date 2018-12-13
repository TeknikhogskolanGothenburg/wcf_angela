﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalRest
{
   

    [DataContract]
    public class Car
    {
        private int _id;
        private string _registerNumber;
        private string _brand;
        private string _model;
        private int _year;
        private string _status;
        private int _dayRent;

        [DataMember(Order = 1)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DataMember(Order = 2)]
        public string RegisterNumber
        {
            get { return _registerNumber; }
            set { _registerNumber = value; }
        }



        [DataMember(Order = 3)]
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        [DataMember(Order = 4)]
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        [DataMember(Order = 5)]
        public int DayRent
        {
            get { return _dayRent; }
            set { _dayRent = value; }
        }

        [DataMember(Order = 6)]
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        [DataMember(Order = 7)]
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }



    }


}
