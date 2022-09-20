public class Customer
{
    uint socialSecurityNum;

    public string Name {
        get; private set;
    }
    List<Account> accounts = new List<Account>();
    public Customer(string name, uint socialSecNum) {
        this.Name = name;
        this.socialSecurityNum = socialSecNum;
    }

    public uint GetId() {
        return socialSecurityNum;
    }
}
