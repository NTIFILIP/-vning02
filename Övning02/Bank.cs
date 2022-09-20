public class Bank
{
    List<Customer> customers = new List<Customer>();
    List<Account> accounts = new List<Account>();

    int transactionsMade = 0;
    int balanceTransferred = 0;

    public string Name {
        get; private set;
    }
    public Bank(string name) {
        this.Name = name;
    }

    public Customer CreateCustomer(string customerName, uint socialSecNum) {
        Customer newCustomer = null;
        Customer alreadyExistingCustomer = FindCustomer(socialSecNum);

        if (alreadyExistingCustomer != null) {
            System.Console.WriteLine("There is already a customer with this SSN!");
        } else {
            newCustomer = new Customer(customerName, socialSecNum);
            customers.Add(newCustomer);
            System.Console.WriteLine("Account successfully created!");       
        }        
        return newCustomer;
    }

    public Account CreateAccount(Customer customer, Decimal balance) {
        Account newAccount = new Account(customer, balance);
        accounts.Add(newAccount);
        return newAccount;
    }

    public Customer FindCustomer(uint socialSecNum) {
        Customer foundCustomer = null;
        foreach (Customer customer in customers) {
            if (customer.GetId() == socialSecNum) {
                foundCustomer = customer;
                break;
            }
        }
        return foundCustomer;
    }
}
