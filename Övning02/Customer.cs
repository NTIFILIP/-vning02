public class Customer
{
    int socialSecurityNum;

    public string Name {
        get; private set;
    }
    List<Account> accounts = new List<Account>();
    public Customer(string name, int socialSecNum) {
        this.Name = name;
        this.socialSecurityNum = socialSecNum;
    }
}
