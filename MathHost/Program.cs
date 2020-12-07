using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using MathLib;

namespace MathHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8000/ThreeDimensionalMath");

            ServiceHost selfHost = new ServiceHost(typeof(Service1), baseAddress);

            try
            {
                selfHost.AddServiceEndpoint(typeof(IService1), new WSHttpBinding(), "Service1");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();
                Console.WriteLine($"The {"Service1"} service is ready.");

                Console.WriteLine("Press <Enter> to terminate.");
                Console.WriteLine();
                Console.ReadLine();
                selfHost.Close();
            }
            catch (CommunicationException e)
            {
                Console.WriteLine($"An error has occured {e.Message}");
                selfHost.Abort();
            }
        }
    }
}
