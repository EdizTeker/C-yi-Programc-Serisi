using System;
using System.Xml.Linq;

namespace Interfaces

{
    class Program
    {
        static void Main(string[] args)
        {
           //IPersonManager personManager new IPersonManager(); You can't new an interface
           
           //IPersonManager customerManager = new CustomerManager();
           //IPersonManager employeeManager = new EmployeeManager();
           ProjectManager projectManager = new ProjectManager();   
           projectManager.Add(new EmployeeManager());    

        }
    }

    interface IPersonManager
    {
        void Add();
        void Update();
    }

    //you need to implement every method of an interface for it to work
    //inherits - class ----------- implements - interface

    class CustomerManager : IPersonManager 
    {
        public void Add()
        {
            Console.WriteLine("Customer added");
        }
        public void Update()
        {
            Console.Write("Customer updated");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee added");
        }
        public void Update()
        {
            Console.WriteLine("Employee updated");
        }

    }

    //One of the reasons to use interfaces is, to add a new code or a new function without altering the current ones

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        { 
            personManager.Add();  

        }


    }
}
