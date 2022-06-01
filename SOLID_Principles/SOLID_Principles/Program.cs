using System;
using System.Net;
using System.Net.Mail;
namespace SOLID_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDetails.GetEmployees();
            EmailNotification.SendEmail();
       
            Console.WriteLine("Hello World!");
        }
    }
}

// Display Employee Details => class Employee

// Delete Employee Record
// Send Email Notification