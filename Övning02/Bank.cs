public class Bank
{
    Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
    Dictionary<int, Account> accounts = new Dictionary<int, Account>();

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
            customers.Add(socialSecNum, newCustomer);
            System.Console.WriteLine("Account successfully created!");       
        }        
        return newCustomer;
    }

    public Account CreateAccount(Decimal balance) {
        Account newAccount = new Account(balance, accounts.Count);
        accounts.Add(accounts.Count, newAccount);
        return newAccount;
    }

    public Customer FindCustomer(int socialSecNum) {
        Customer foundCustomer = null;
        customers.TryGetValue(socialSecNum, out foundCustomer);
        return foundCustomer;
    }

    public Account FindAccount(int id) {
        Account foundAccount = null;
        accounts.TryGetValue(id, out foundAccount);
        return foundAccount;
    }
}
