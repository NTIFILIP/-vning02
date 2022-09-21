public class Account
{
    Customer owner;
    Decimal balance;
    public int ID {get; private set;}
    List<Transaction> transactions = new List<Transaction>();
    public Account(Decimal balance, int accountId) {
        this.balance = balance;
        this.ID = accountId;

        Console.Clear();
        System.Console.WriteLine($"A new account was created with the ID: {accountId}\n");
    }

    public void SetOwner(Customer newOwner) {
        owner = newOwner;
    }
}
