using EmployeeService;
using Grpc.Net.Client;
using System;

namespace AppClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // client..
                var channel = GrpcChannel.ForAddress("https://localhost:5001");
                var client = new Employees.EmployeesClient(channel);

                request:
                Console.Write("Enter Lookup Id: ");
                var id = Convert.ToInt32(Console.ReadLine());
                var request = new EmployeeId { Id = id };

                var response = client.GetEmployee(request);
                Console.WriteLine(response);
                goto request;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
           
        }
    }
}
