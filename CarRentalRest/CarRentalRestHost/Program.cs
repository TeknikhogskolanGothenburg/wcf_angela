using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalRestHost
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceHost host = new WebServiceHost(typeof(CarRentalRest.CarRentalRestService),
                new Uri("http://localhost:8080"));

            ServiceEndpoint ep = host.AddServiceEndpoint(
                typeof(CarRentalRest.ICarRentalRestService), new WebHttpBinding(), "");

            host.Description.Endpoints[0].Behaviors.Add(
                new WebHttpBehavior { HelpEnabled = true });

            ServiceDebugBehavior sdb = host.Description.Behaviors.Find<ServiceDebugBehavior>();

            sdb.IncludeExceptionDetailInFaults = true;
            //sdb.HttpsHelpPageEnabled = true;

            host.Open();
            Console.WriteLine("Service is running");
            Console.ReadLine();
            host.Close();
        }
    }
}
