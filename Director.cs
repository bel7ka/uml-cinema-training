using System.Dynamic;

public class Director
{
    private string firstName;
    private string lastName;
    private string country;

    public Director(string firstName, string lastName, string country)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.country = country;
    }
    public void Display()
    {
        Console.WriteLine($"Director: {firstName} {lastName}, Country: {country}");
    }

    public string GetFirstName()
    {
        return firstName;
    }
    public void SetFirstName(string value)
    {
        firstName = value;
    }

    public string GetLastName()
    {
        return lastName;
    }
    public void SetLastName(string value)
    {
        lastName = value;
    }

    public string GetCountry()
    {
        return country;
    }
    public void SetCountry(string value)
    {
        country = value;
    }

}