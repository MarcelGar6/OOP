using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceApplication.Models;

namespace EcommerceApplication.Services.Infrastructure
{
    public interface ICostumer
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);
        void Insert(Customer cust);
        void Update(Customer cust);
        void Delete(int id);
        void Save();
    }
}
