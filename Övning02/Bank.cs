public class Bank
{
    List<Customer> customers = new List<Customer>();
    List<Account> accounts = new List<Account>();
    public string Name {
        get; private set;
    }
    public Bank(string name) {
        this.Name = name;
    }

    Customer CreateCustomer(string customerName, int socialSecNum) {
        Customer newCustomer = new Customer(customerName, socialSecNum);
        customers.Add(newCustomer);
        return newCustomer;
    }
}
