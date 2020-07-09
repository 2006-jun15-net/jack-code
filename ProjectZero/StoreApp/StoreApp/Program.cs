using BuisnessLogic.Library.Repos;
using DataAccess.Library.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using DataAccess.Library.Repos;
using System.Net.Http.Headers;

namespace StoreApp
{
    class Program
    {
        public static readonly DbContextOptions<projectZeroContext> Options = new DbContextOptionsBuilder<projectZeroContext>()
           .UseSqlServer(SecretConfiguration.ConnectionString)
           .Options;
        static void Main(string[] args) {


         


            using (var unitofWork = new UnitOfWork(new projectZeroContext(DbContextOptionsBuilder)))
            {
                var customer = new Customer { FirstName = "Jack", LastName = "Pflug" };
                unitofWork.Customers.Add(customer);
                unitofWork.Complete();
                var getCustomer = unitofWork.Customers.GetAll();
                var printCustomer = string.Join(" ,", getCustomer);
                Console.WriteLine($"{printCustomer}"); 


            }

            //displayCustomers(); 
           
        }


        //public static void displayCustomers()
        //{
          
                

        //}

    }

    
    
}


