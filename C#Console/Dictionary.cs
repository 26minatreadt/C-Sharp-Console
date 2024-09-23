class Dictionary
{
    public static void Dict1(string[] args) {

        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        phonebook.Add("Alice", "123-456-7890");
        phonebook.Add("Bob", "987-654-3210");

        Console.WriteLine(phonebook["Alice"]);
    }

    public static void Dict2(string[] args) {

        Dictionary<string, int> inventory = new Dictionary<string, int>();
        inventory.Add("Apples", 50);
        inventory.Add("Bannanas", 25);
        inventory.Add("Arrows", 23);
        inventory.Add("Sword", 1);
        inventory.Add("Bow", 1);

        foreach(KeyValuePair<string, int> item in inventory) {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
    
}