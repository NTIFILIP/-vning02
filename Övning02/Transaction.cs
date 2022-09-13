using System;

public class Transaction
{   
    Account origin;
    Account destination;
    Decimal amount;
    DateTime date;
    public Transaction(Account origin, Account destination, Decimal amount) {
        this.origin = origin;
        this.destination = destination;
        this.amount = amount;
        this.date = DateTime.Now;
    }
}
