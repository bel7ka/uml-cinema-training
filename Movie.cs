using System.Dynamic;

public class Movie
{
    private string title;
    private string duration;
    public void Display()
    {
        Console.WriteLine($"Title: {title}, Duration: {duration}");
    }

    public string title
    {
        get { return title; }
        set { title = value; }
    }
    public string duration
    {
        get { return duration; }
        set { duration = value; }
    }

}