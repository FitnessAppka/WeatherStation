using Database;

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("Ja", 999);
        User user2 = new User("Ja", 999);

        Sensor sensor1 = new Sensor();
        Console.WriteLine(user1.Equals(user2));

    }
}