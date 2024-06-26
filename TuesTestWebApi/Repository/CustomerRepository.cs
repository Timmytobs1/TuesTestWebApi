using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using TuesTestWebApi.Data;
using TuesTestWebApi.Dtos.Customer;
using TuesTestWebApi.Interface;
using TuesTestWebApi.Mappers;
using TuesTestWebApi.Model;

namespace TuesTestWebApi.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool CheckCustomer(Guid id)
        {
            var check = _context.Customers.Any(x => x.Id == id);
            return check;
        }

    

        public CustomerDto? DeleteCustomer(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerDto> GetAllCustomers()
        {
            var customers = _context.Customers.Include(y => y.Account).Select(x => x.ToCustomerDtoFromModel()).ToList();
            return customers;
        }

        public CustomerDto? GetCustomer(Guid id)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == id);
            if (customer == null)
            {
                return null;
            }
            return customer.ToCustomerDtoFromModel();
        }

        public CustomerDto RegisterCustomer(CreateCustomerDto customerDto)
        {
            var customer = customerDto.ToCustomerModel();
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer.ToCustomerDtoFromModel();
        }

        public CustomerDto? UpdateCustomer(Guid id, UpdateCustomerDto customerDto)
        {
            throw new NotImplementedException();
        }

        public bool UpgradeTier(Guid id)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == id);
            if (customer == null)
            {
                return false;
            }
            if (customer.Tier > 2)
            {

                return false;
            }
            customer.Tier += 1;
            _context.SaveChanges();
            return true;
        }
    }
}
