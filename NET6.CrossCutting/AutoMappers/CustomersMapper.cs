using AutoMapper;
using NET6.Infrastructure.Models.Customers.Responses;

namespace NET6.CrossCutting.AutoMappers
{
    internal class CustomersMapper : Profile
    {
        public CustomersMapper()
        {
            CreateMap<CustomerResponse, CustomerOutput>();
        }
    }
}
