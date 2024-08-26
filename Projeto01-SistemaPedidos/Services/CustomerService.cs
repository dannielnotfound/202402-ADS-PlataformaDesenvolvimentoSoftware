using Projeto01_OrdersManager.Models;
using Projeto01_OrdersManager.Repositories;

namespace Projeto01_OrdersManager.Services {
  public class CustomerService {
    private readonly CustomerRepository _customerRepository;

    public CustomerService(CustomerRepository customerRepository) {
      _customerRepository = customerRepository;
    }

    public async Task<Customer> GetCustomer(string customerId) {
      return await _customerRepository.GetCustomer(customerId);
    }
  }
}