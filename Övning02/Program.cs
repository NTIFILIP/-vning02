Bank bank = new Bank("Bästa banken");

string GetChoiceInput(string prompt, string[] choices) {
    string input;
    while (true) {
        Console.Write(prompt);
        input = Console.ReadLine();

        if (choices.Contains(input)) {
            break;
        } else {
            Console.Clear();
            System.Console.WriteLine("Your input was invalid, try again!\n");
        }
    }
    return input;
}

bool ValidateSocialSecNum(int num) {
    return num >= 0;
}

int GetIntInput(string prompt, Func<int, bool> validationFunc=null) {
    int number;
    while (true) {
        Console.Write(prompt);
        bool success = int.TryParse(Console.ReadLine(), out number);
        if (success && (validationFunc==null || validationFunc(number))) {
            break;
        } else {
            Console.Clear();
            System.Console.WriteLine("Your input was invalid, try again!\n");
        }
    }
    return number;
}

int GetSocialSecNum() {
    string prompt = "Please input your social security number (SSN): ";
    int socialSecNum = GetIntInput(prompt, ValidateSocialSecNum);
    return socialSecNum;
}

void CreateNewCustomer() {
    Console.Write("Please input your name to continue: ");
    string name = Console.ReadLine().ToLower();

    int socialSecNum = GetSocialSecNum();

    Console.Clear();
    bank.CreateCustomer(name, socialSecNum);
}

void CreateNewAccount() {
    decimal balance;
    while (true) {
        Console.Write("\nPlease input the starting balance of the account: ");
        bool success = decimal.TryParse(Console.ReadLine(), out balance);
        if (success) {
            break;
        } else {
            Console.Clear();
            System.Console.WriteLine("Your input was invalid, try again!\n");
        }
    } 
    Account newAccount = bank.CreateAccount(balance);
}

void ConnectAccount() {
    int socialSecNum = GetSocialSecNum();
    Customer customer = bank.FindCustomer(socialSecNum);
    if (customer == null) {
        System.Console.WriteLine("There is no customer with that SSN!");
        return;
    }

    string prompt = $"Please input the ID of the account you wish to connect to '{customer.Name}': ";
    int accountId = GetIntInput(prompt);
    Account account = bank.FindAccount(accountId);
    if (account == null) {
        System.Console.WriteLine("There is no account with this ID!");
        return;
    }

    account.SetOwner(customer);

}

while (true) {
    string prompt = $"Welcome to '{bank.Name}', what would you like to do today?"
    + "\n[1]: New Customer"
    + "\n[2]: Create Account"
    + "\n[3]: Connect Account to Customer"
    + "\n[4]: Transfer Balance"
    + "\n[5]: Display Bank Statistics\n"
    + "----------------------------------------\n\n";

    string[] choices = {"1", "2", "3", "4", "5"};
    string input = GetChoiceInput(prompt, choices);
    Console.Clear();
    switch (input) {
        case "1":
            CreateNewCustomer();
            break; 
        case "2":
            CreateNewAccount();
            break;
        case "3":
            ConnectAccount();
            break; 
        case "4":
            break;
        case "5":
            break; 
    }
    System.Console.WriteLine("");
}


