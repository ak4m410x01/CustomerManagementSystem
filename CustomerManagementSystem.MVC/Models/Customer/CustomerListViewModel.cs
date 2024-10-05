namespace CustomerManagementSystem.MVC.Models.Customer
{
    public class CustomerListViewModel
    {
        public IEnumerable<CustomerViewModel> Customers { get; set; } = new List<CustomerViewModel>();
    }
}