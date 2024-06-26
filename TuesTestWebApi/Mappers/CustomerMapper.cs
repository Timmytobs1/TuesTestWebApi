using TuesTestWebApi.Dtos.Customer;
using TuesTestWebApi.Model;

namespace TuesTestWebApi.Mappers
{
    public static class CustomerMapper
    {
        public static Customer ToCustomerModel(this CreateCustomerDto createCustomerDto)
        {
            return new Customer
            {
               FirstName = createCustomerDto.FirstName,
               LastName = createCustomerDto.LastName,
               Address = createCustomerDto.Address,
               Age = createCustomerDto.Age,
               Email = createCustomerDto.Email,
               PhoneNo = createCustomerDto.PhoneNo,
            };
        }

        public static CustomerDto ToCustomerDtoFromModel(this Customer customer)
        {
            return new CustomerDto
            {
             Id = customer.Id,
             FirstName = customer.FirstName,
             LastName = customer.LastName,
             Address = customer.Address,
             Age = customer.Age,
             Email = customer.Email,
             Tier = customer.Tier,
             PhoneNo = customer.PhoneNo,
             CreatedAt = customer.CreatedAt,
             UpdatedAt = customer.UpdatedAt,
            };
        }
    }
}
