using System.Dynamic;

public class Director
{
    private string firstName;
    private string lastName;
    private string country;
    public void Display()
    {
        Console.WriteLine($"Director: {firstName} {lastName}, Country: {country}");
    }

    public string firstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string lastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public string country
    {
        get { return country;}
        set {country = value;}
    }

}