using System;
using System.Xml.Linq;

namespace ReferenceTypes

{
class Program
{
        static void Main(string[] args)
        {
            int number1 = 7;
            int number2 = 8;

            number1 = number2;

            number2 = 58;

            Console.WriteLine("number1 = " + number1);
            //The reason number1 isn't 58 is because int, decimal, float, boolean, etc. are value types 

            int[] numbers1 = { 4, 5, 6 };
            int[] numbers2 = { 7, 8, 9 };

            numbers1 = numbers2;

            numbers2[0] = 50;

            Console.WriteLine("numbers1[0] = " + numbers1[0]);
            //But here, numbers1[0 IS 50 because arrays, class, interface, etc. are reference types

            Person person1 = new Person();
            Person person2 = new Person();  

            person1.FirstName = "Melis";

            person2 = person1; 
            person1.FirstName = "Yasemin";
            
            Console.WriteLine("person2's name = " + person2.FirstName);
            //Same as the last one, class is a reference type so person2's name changes with person1'S

            Employee employee = new Employee();
            Customer customer = new Customer();
            customer.FirstName = "Kaan";
            customer.CreditCardNumber = "12345678910";

            Person person3 = customer; 
            //This works because all employees and customers are persons, person class contains the other two

            Console.WriteLine("person3's name = " + person3.FirstName); 
            Console.WriteLine("person3's Credit card number = " + ((Customer)person3).CreditCardNumber); //boxing (look later)

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            //personManager.Add(employee);
            personManager.Add(person2);


            Console.ReadKey();

        }
}

    internal class Person 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    internal class Customer : Person 
    {
        public string CreditCardNumber { get; set; }
    }

    internal class Employee : Person 
    {
        public int EmployeeNumber { get; set; }
    }

    internal class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName + " added");
        }
    }
}