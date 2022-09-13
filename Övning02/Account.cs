public class Account
{
    Customer owner;
    Decimal balance;
    List<Transaction> transactions = new List<Transaction>();
    public Account(Customer owner, Decimal balance) {
        this.owner = owner;
        this.balance = balance;
    }

    
}
