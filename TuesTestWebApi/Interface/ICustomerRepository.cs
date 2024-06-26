
using TuesTestWebApi.Dtos.Customer;
using TuesTestWebApi.Model;

namespace TuesTestWebApi.Interface
{
    public interface ICustomerRepository
    {
        public List<CustomerDto> GetAllCustomers();
        public CustomerDto? GetCustomer(Guid id);
        public CustomerDto RegisterCustomer(CreateCustomerDto customerDto);
        public CustomerDto? UpdateCustomer(Guid id, UpdateCustomerDto customerDto);
        public CustomerDto? DeleteCustomer(Guid id);
        public bool UpgradeTier(Guid id);
        public bool CheckCustomer(Guid id);
    }
}
