namespace NET6.Domain.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Task<CustomerOutput> AddCustomerAsync(CustomerInput customer, CancellationToken cancellationToken);
    }
}
