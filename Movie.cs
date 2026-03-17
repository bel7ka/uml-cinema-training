using System.Dynamic;

public class Movie
{
    private string title;
    private string duration;
    public void Display()
    {
        Console.WriteLine($"Title: {title}, Duration: {duration}");
    }

    public string GetTitle()
    {
        return title;
    }
    public void SetTitle(string value)
    {
        title = value;
    }
    public string GetDuration()
    {
        return duration;
    }
    public void SetDuration(string value)
    {
        duration = value;
    }

}