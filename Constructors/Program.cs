using System;
using System.Xml.Linq;

namespace Constructors

{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Kaan", LastName = "Dere", City = "Rize" };
            
            Customer customer2 = new Customer();
            customer2.Id = 2;
            //These two means the same thing and works the same way but written differently

            
            
            Customer customer3 = new Customer (3, "Mehmet", "Demir", "İzmir");
            //This one uses a constructor to assign value to the variables
            Console.WriteLine(customer3.FirstName);


        }
    }

    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city) 
        {
            //Console.WriteLine("Constructor started");

            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;


        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}