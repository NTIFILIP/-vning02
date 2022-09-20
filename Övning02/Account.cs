public class Account
{
    Customer owner;
    Decimal balance;
    int ID;
    List<Transaction> transactions = new List<Transaction>();
    public Account(Customer owner, Decimal balance) {
        this.owner = owner;
        this.balance = balance;
    }
}
