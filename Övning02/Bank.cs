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

    public Customer CreateCustomer(string customerName, int socialSecNum) {
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

    public Account CreateAccount(Decimal balance) {
        Account newAccount = new Account(balance, accounts.Count);
        accounts.Add(newAccount);
        return newAccount;
    }

    public Customer FindCustomer(int socialSecNum) {
        Customer foundCustomer = null;
        foreach (Customer customer in customers) {
            if (customer.GetId() == socialSecNum) {
                foundCustomer = customer;
                break;
            }
        }
        return foundCustomer;
    }

    public Account FindAccount(int id) {
        Account foundAccount = null;
        foreach (Account account in accounts) {
            if (account.ID == id) {
                foundAccount = account;
                break;
            }
        }
        return foundAccount;
    }
}
