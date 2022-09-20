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

void CreateNewCustomer() {
    Console.Write("Please input your name to continue: ");
    string name = Console.ReadLine().ToLower();

    uint number;
    while (true) {
        Console.Write("\nPlease input your social security number (SSN): ");
        bool success = uint.TryParse(Console.ReadLine(), out number);
        if (success) {
            break;
        } else {
            Console.Clear();
            System.Console.WriteLine("Your input was invalid, try again!\n");
        }
    }

    Console.Clear();
    bank.CreateCustomer(name, number);
}

void CreateNewAccount() {

}

Customer currentCustomer;

while (true) {
    string prompt = $"\nWelcome to '{bank.Name}', what would you like to do today?"
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
            break;
        case "3":
            break; 
        case "4":
            break;
        case "5":
            break; 
    }
}


