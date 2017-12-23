using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI_Test.Entity;

namespace WebAPI_Test.DLL
{
    public class SampleData
    {
        internal static List<Customer> GetSmapleDataFromCustomerTable()
        {
            List<Customer> custList = new List<Customer>();
            custList.Add(new Customer() { Id = 1, FirstName = "Abhishek", LastName = "Kumar", Email = "abhishek@gmail.com", Mobile = 8123045738, City = "Bangalore", Address = "Bangalore, 560027" });
            custList.Add(new Customer() { Id = 2, FirstName = "Sumit", LastName = "Kumar", Email = "sumit@gmail.com", Mobile = 8676352677, City = "Bangalore", Address = "Bangalore, 560024" });

            return custList;
        }
    }
}