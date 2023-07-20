using SportsShop.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShop.WebApi.Services
{
    public class CustomerService : ICustomerService
    {
        public Task<Customer> CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetCustomersList()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
