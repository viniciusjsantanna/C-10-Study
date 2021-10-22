namespace NET6.Infrastructure.Repositories;
public class CustomerRepository : ICustomerRepository
{
    public Task<CustomerOutput> AddCustomerAsync(CustomerInput customer, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
