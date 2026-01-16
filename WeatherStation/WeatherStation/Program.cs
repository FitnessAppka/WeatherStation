using Database;
using Database.MyContent;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        using (var MyContext = new MyAplicationContext())
        {
            MyContext.Database.EnsureCreated();
        }

        Console.WriteLine("dwa");
    }
}