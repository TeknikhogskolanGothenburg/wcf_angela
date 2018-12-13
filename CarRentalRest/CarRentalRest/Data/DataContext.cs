using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalRest.Data
{
    public class DataContext
    {
        public Car GetCar(Car newCar)
        {
            Car car = new Car();
            string cs = ConfigurationManager.ConnectionStrings["CRCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetCar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                parameterId.Value = newCar.Id;

                cmd.Parameters.Add(parameterId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    car.Id = Convert.ToInt32(reader["Id"]);
                    car.RegisterNumber = reader["RegisterNumber"].ToString();
                    car.Brand = reader["Brand"].ToString();
                    car.Model = reader["Model"].ToString();
                    car.DayRent = Convert.ToInt32(reader["DayRent"]);
                    car.Year = Convert.ToInt32(reader["Year"]);
                    car.Status = reader["Status"].ToString();
                }

            }
            return car;
            
        }

        public List<Car> GetCars()
        {
            List<Car> cars = new List<Car>();
            string cs = ConfigurationManager.ConnectionStrings["CRCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetCars", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Car car = new Car();
                    car.Id = Convert.ToInt32(reader["Id"]);
                    car.RegisterNumber = reader["RegisterNumber"].ToString();
                    car.Brand = reader["Brand"].ToString();
                    car.Model = reader["Model"].ToString();
                    car.DayRent = Convert.ToInt32(reader["DayRent"]);
                    car.Year = Convert.ToInt32(reader["Year"]);
                    car.Status = reader["Status"].ToString();
                    cars.Add(car);
                }
            }
            return cars;

        }

        public void SaveCar(Car car)
        {
            string cs = ConfigurationManager.ConnectionStrings["CRCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spSaveCar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter
                {
                    ParameterName = "@Id",
                    Value = car.Id
                };
                cmd.Parameters.Add(parameterId);

                SqlParameter parameterRegisterNumber = new SqlParameter
                {
                    ParameterName = "@RegisterNumber",
                    Value = car.RegisterNumber
                };
                cmd.Parameters.Add(parameterRegisterNumber);

                SqlParameter parameterBrand = new SqlParameter
                {
                    ParameterName = "@Brand",
                    Value = car.Brand
                };
                cmd.Parameters.Add(parameterBrand);


                SqlParameter parameterModel = new SqlParameter
                {
                    ParameterName = "@Model",
                    Value = car.Model
                };
                cmd.Parameters.Add(parameterModel);

                SqlParameter parameterDayRent = new SqlParameter
                {
                    ParameterName = "@DayRent",
                    Value = car.DayRent
                };
                cmd.Parameters.Add(parameterDayRent);

                SqlParameter parameterYear = new SqlParameter
                {
                    ParameterName = "@Year",
                    Value = car.Year
                };
                cmd.Parameters.Add(parameterYear);

                SqlParameter parameterStatus = new SqlParameter
                {
                    ParameterName = "@Status",
                    Value = car.Status
                };
                cmd.Parameters.Add(parameterStatus);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCarStatus(Car car)
        {
            string cs = ConfigurationManager.ConnectionStrings["CRCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spUpdateCar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter
                {
                    ParameterName = "@Id",
                    Value = car.Id
                };
                cmd.Parameters.Add(parameterId);


                SqlParameter parameterStatus = new SqlParameter
                {
                    ParameterName = "@Status",
                    Value = car.Status
                };
                cmd.Parameters.Add(parameterStatus);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCar(Car car)
        {
            string cs = ConfigurationManager.ConnectionStrings["CRCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spDeleteCar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                parameterId.Value = car.Id;

                cmd.Parameters.Add(parameterId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public Customer GetCustomer(Customer newCustomer)
        {
            Customer customer = new Customer();
            string cs = ConfigurationManager.ConnectionStrings["CRCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                parameterId.Value = newCustomer.Id;

                cmd.Parameters.Add(parameterId);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool isExist = false;
                    while (reader.Read())
                    {
                        isExist = true;

                        if ((CustomerType)reader["CustomerType"] == CustomerType.PayAsGoCustomer)
                        {
                            customer = new PayAsGoCustomer
                            {
                                CustomerType = CustomerType.PayAsGoCustomer

                            };
                        }
                        else
                        {
                            customer = new ContractCustomer
                            {
                                CustomerType = CustomerType.ContractCustomer,
                                Discount = Convert.ToDecimal(reader["Discount"])
                            };
                        }

                        customer.Id = Convert.ToInt32(reader["Id"]);
                        customer.FirstName = reader["FirstName"].ToString();
                        customer.LastName = reader["LastName"].ToString();
                        customer.Mobile = reader["Mobile"].ToString();
                        customer.Email = reader["Email"].ToString();
                    }
                    if (!isExist)
                    {
                        throw new FaultException("Customer id " + newCustomer.Id.ToString() + " does not exist");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return customer;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            Customer customer = new Customer();
            string cs = ConfigurationManager.ConnectionStrings["CRCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetCustomers", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if ((CustomerType)reader["CustomerType"] == CustomerType.PayAsGoCustomer)
                    {
                        customer = new PayAsGoCustomer
                        {
                            CustomerType = CustomerType.PayAsGoCustomer

                        };
                    }
                    else
                    {
                        customer = new ContractCustomer
                        {
                            CustomerType = CustomerType.ContractCustomer,
                            Discount = Convert.ToDecimal(reader["Discount"])

                        };
                    }
                    customer.Id = Convert.ToInt32(reader["Id"]);
                    customer.FirstName = reader["FirstName"].ToString();
                    customer.LastName = reader["LastName"].ToString();
                    customer.Mobile = reader["Mobile"].ToString();
                    customer.Email = reader["Email"].ToString();

                    customers.Add(customer);

                }
            }
            return customers;
        }


        public void SaveCustomer(Customer customer)
        {
            string cs = ConfigurationManager.ConnectionStrings["CRCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spSaveCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //var parameterCustomerId = customer.Id;
                //var parameterCustomerFirstName = customer.FirstName;
                //var parameterCustomerLastName = customer.LastName;
                //var parameterCustomerMobile = customer.Mobile;
                //var parameterCustomerEmail = customer.Email;

                SqlParameter parameterCustomerId = new SqlParameter
                {
                    ParameterName = "@Id",
                    Value = customer.Id
                };
                cmd.Parameters.Add(parameterCustomerId);

                SqlParameter parameterCustomerFirstName = new SqlParameter
                {
                    ParameterName = "@FirstName",
                    Value = customer.FirstName
                };
                cmd.Parameters.Add(parameterCustomerFirstName);

                SqlParameter parameterCustomerLastName = new SqlParameter
                {
                    ParameterName = "@LastName",
                    Value = customer.LastName
                };
                cmd.Parameters.Add(parameterCustomerLastName);


                SqlParameter parameterCustomerMobile = new SqlParameter
                {
                    ParameterName = "@Mobile",
                    Value = customer.Mobile
                };
                cmd.Parameters.Add(parameterCustomerMobile);

                SqlParameter parameterCustomerEmail = new SqlParameter
                {
                    ParameterName = "@Email",
                    Value = customer.Email
                };
                cmd.Parameters.Add(parameterCustomerEmail);

                SqlParameter parameterType = new SqlParameter
                {
                    ParameterName = "@CustomerType",
                    Value = customer.CustomerType
                };
                cmd.Parameters.Add(parameterType);

                if (customer.GetType() == typeof(ContractCustomer))
                {
                    SqlParameter parameterContractDiscount = new SqlParameter
                    {
                        ParameterName = "@Discount",
                        Value = ((ContractCustomer)customer).Discount
                    };
                    cmd.Parameters.Add(parameterContractDiscount);
                };

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        public void UpdateCustomer(Customer customer)
        {
            string cs = ConfigurationManager.ConnectionStrings["CRCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spUpdateCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterCustomerId = new SqlParameter
                {
                    ParameterName = "@Id",
                    Value = customer.Id
                };
                cmd.Parameters.Add(parameterCustomerId);

                SqlParameter parameterCustomerFirstName = new SqlParameter
                {
                    ParameterName = "@FirstName",
                    Value = customer.FirstName
                };
                cmd.Parameters.Add(parameterCustomerFirstName);

                SqlParameter parameterCustomerLastName = new SqlParameter
                {
                    ParameterName = "@LastName",
                    Value = customer.LastName
                };
                cmd.Parameters.Add(parameterCustomerLastName);


                SqlParameter parameterCustomerMobile = new SqlParameter
                {
                    ParameterName = "@Mobile",
                    Value = customer.Mobile
                };
                cmd.Parameters.Add(parameterCustomerMobile);

                SqlParameter parameterCustomerEmail = new SqlParameter
                {
                    ParameterName = "@Email",
                    Value = customer.Email
                };
                cmd.Parameters.Add(parameterCustomerEmail);

                SqlParameter parameterType = new SqlParameter
                {
                    ParameterName = "@CustomerType",
                    Value = customer.CustomerType
                };
                cmd.Parameters.Add(parameterType);

                if (customer.GetType() == typeof(ContractCustomer))
                {
                    SqlParameter parameterContractDiscount = new SqlParameter
                    {
                        ParameterName = "@Discount",
                        Value = ((ContractCustomer)customer).Discount
                    };
                    cmd.Parameters.Add(parameterContractDiscount);
                };

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        public void DeleteCustomer(Customer customer)
        {

            string cs = ConfigurationManager.ConnectionStrings["CRCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spDeleteCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                parameterId.Value = customer.Id;

                cmd.Parameters.Add(parameterId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public Booking GetBooking(Booking newBooking)
        {
            Booking booking = new Booking();
            Car car = new Car();
            Customer customer = new Customer();
            string cs = ConfigurationManager.ConnectionStrings["CRCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetBooking", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                parameterId.Value = newBooking.Id;

                cmd.Parameters.Add(parameterId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    booking.Id = Convert.ToInt32(reader["Id"]);
                    booking.StartTime = DateTime.Parse(reader["StartTime"].ToString());
                    booking.ReturnTime = DateTime.Parse(reader["ReturnTime"].ToString());
                    booking.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                    booking.CarId = Convert.ToInt32(reader["CarId"]);
                    car.Id = booking.CarId;
                    car.RegisterNumber = reader["RegisterNumber"].ToString();
                    car.Brand = reader["Brand"].ToString();
                    car.Model = reader["Model"].ToString();
                    car.DayRent = Convert.ToInt32(reader["DayRent"]);
                    car.Year = Convert.ToInt32(reader["Year"]);
                    customer.Id = booking.CustomerId;
                    customer.FirstName = reader["FirstName"].ToString();
                    customer.LastName = reader["LastName"].ToString();
                    customer.Email = reader["Email"].ToString();
                }
            }
            return booking;
        }


        public List<Booking> GetBookings()
        {
            List<Booking> bookings = new List<Booking>();
            string cs = ConfigurationManager.ConnectionStrings["CRCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetBookings", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Booking booking = new Booking();
                    booking.Id = Convert.ToInt32(reader["Id"]);
                    booking.StartTime = DateTime.Parse(reader["StartTime"].ToString());
                    booking.ReturnTime = DateTime.Parse(reader["ReturnTime"].ToString());
                    booking.CarId = Convert.ToInt32(reader["CarId"]);
                    booking.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                    bookings.Add(booking);
                }
            }
            return bookings;
        }

        public void SaveBooking(Booking booking)
        {
            string cs = ConfigurationManager.ConnectionStrings["CRCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spSaveBooking", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter
                {
                    ParameterName = "@Id",
                    Value = booking.Id
                };
                cmd.Parameters.Add(parameterId);

                SqlParameter parameterStartTime = new SqlParameter
                {
                    ParameterName = "@StartTime",
                    Value = booking.StartTime
                };
                cmd.Parameters.Add(parameterStartTime);

                SqlParameter parameterReturnTime = new SqlParameter
                {
                    ParameterName = "@ReturnTime",
                    Value = booking.ReturnTime
                };
                cmd.Parameters.Add(parameterReturnTime);


                SqlParameter parameterCarId = new SqlParameter
                {
                    ParameterName = "@CarId",
                    Value = booking.CarId
                };
                cmd.Parameters.Add(parameterCarId);

                SqlParameter parameterCustomerId = new SqlParameter
                {
                    ParameterName = "@CustomerId",
                    Value = booking.CustomerId
                };
                cmd.Parameters.Add(parameterCustomerId);



                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteBooking(Booking booking)
        {

            string cs = ConfigurationManager.ConnectionStrings["CRCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spDeleteBooking", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                parameterId.Value = booking.Id;

                cmd.Parameters.Add(parameterId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
