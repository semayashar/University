using System;

class C_Message : C_MessageContainer
{
    private string user;
    private DateTime now = DateTime.Now;
    private string message;


    //constructors
    public C_Message()
    {
        user = "";
        message = "";
    }
    public C_Message(string user, string mes)
    {
        setUser(user);
        setMessage(mes);
    }



    //setter and getter message
    public string getMessage()
    {
        return message;
    }
    public void setMessage(string text)
    {
        message = text;
    }



    //getter time
    public DateTime getDate()
    {
        return now;
    }



    //setter and getter user
    public string getUser()
    {
        return user;
    }
    public void setUser(string text)
    {
        user = text;
    }
}

class C_MessageContainer
{
    List<C_Message> messages = new List<C_Message>();

    //Getter and setter:
    public List<C_Message> get()
    {
        return messages;
    }
    public void setMessCon()
    {
        Console.Write("Enter user: ");
        string user = Console.ReadLine();

        Console.Write("Enter text: ");
        string message = Console.ReadLine();

        C_Message newMes = new C_Message(user, message);
        messages.Add(newMes);
    }
    public void deleteMessage(string user1, string text)
    {
        foreach (var item in messages)
        {
            if (item.getUser() == user1 && item.getMessage() == text)
            {
                messages.Remove(item);
                return;
            }
        }
    }
    public void printMessCon()
    {
        foreach (var item in messages)
        {
            Console.WriteLine("\nUser: " + item.getUser() + "\nDate: " + item.getDate() + "\nMessage: " + item.getMessage() + "\n");
        }
    }
    public void printUser()
    {
        Console.Write("Searched user: ");
        string user = Console.ReadLine();

        foreach (var item in messages)
        {
            if (item.getUser() == user)
            {
                Console.WriteLine("\nUser: " + item.getUser() + "\nDate: " + item.getDate() + "\nMessage: " + item.getMessage() + "\n");
            }
        }
    }
    public void printMessages()
    {
        Console.Write("Searched message: ");
        string mess = Console.ReadLine();

        foreach (var item in messages)
        {
            if (item.getMessage() == mess)
            {
                Console.WriteLine("\nUser: " + item.getUser() + "\nDate: " + item.getDate() + "\nMessage: " + item.getMessage() + "\n");
            }
        }
    }
    public void printLastMessage()
    {
        var lastItem = messages.LastOrDefault();
        Console.WriteLine("\nUser: " + lastItem.getUser() + "\nDate: " + lastItem.getDate() + "\nMessage: " + lastItem.getMessage() + "\n");
    }
    public void printMessageInInterval()
    {
        Console.Write("From\nDay: ");
        int dateF = int.Parse(Console.ReadLine());
        Console.Write("Month: ");
        int monthF = int.Parse(Console.ReadLine());
        Console.Write("Year: ");
        int yearF = int.Parse(Console.ReadLine());

        Console.Write("To\nDay: ");
        int dateT = int.Parse(Console.ReadLine());
        Console.Write("Month: ");
        int monthT = int.Parse(Console.ReadLine());
        Console.Write("Year: ");
        int yearT = int.Parse(Console.ReadLine());


        DateTime t1 = new DateTime(yearF, monthF, dateF);
        DateTime t2 = new DateTime(yearT, monthT, dateT);


        foreach (var item in messages)
        {
            /*int result1 = DateTime.Compare(t1, item.getDate());
            int result2 = DateTime.Compare(t2, item.getDate());*/

            /*if (result1 < 0 && result2 > 0)
            {
                Console.WriteLine("\nUser: " + item.getUser() + "\nDate: " + item.getDate() + "\nMessage: " + item.getMessage() + "\n");
            }
            else if (result1 > 0 && result2 < 0)
            {
                Console.WriteLine("\nUser: " + item.getUser() + "\nDate: " + item.getDate() + "\nMessage: " + item.getMessage() + "\n");
            }*/

            if (t1 < item.getDate() && item.getDate() < t2)
            {
                messages.Remove(item);
            }
            else if (t2 < item.getDate() && item.getDate() < t1)
            {
                messages.Remove(item);
            }
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
     
    }
}