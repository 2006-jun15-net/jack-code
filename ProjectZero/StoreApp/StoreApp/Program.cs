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
        static void Main(string[] args) {
            using (var unitofWork = new UnitOfWork(new projectZeroContext()))
            {

                unitofWork.Customers.Add(new DataAccess.Library.Entities.Customer { FirstName = "Jack", LastName = "Pflug" });
                unitofWork.Complete(); 



            }



    }
    }
}


