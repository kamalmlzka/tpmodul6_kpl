using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title.Length <= 100 && title != null, "Judul video memiliki panjang maksimal 100 karakter dan tidak berupa null.");
        
        this.id = new Random().Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count <= 10000000, "Input penambahan play count maksimal 10.000.000 per panggilan method-nya.");

        try
        {
            checked { this.playCount += count; }
        }
        catch (OverflowException err)
        {
            Console.WriteLine(err.Message);
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("https://sayatube.com/watch?id=" + this.id);
        Console.WriteLine();
        Console.WriteLine(this.title);
        Console.WriteLine(this.playCount.ToString("N0") + " views");
    }
}

public class Program
{
    public static void Main()
    {
        SayaTubeVideo vid = new SayaTubeVideo("Tutorial Design By Contract – KamalMaulaazkaSidhqi_Praktikan");
        for (int i = 0; i < 10000; i++)
        {
            vid.IncreasePlayCount(10000);
        }
        vid.PrintVideoDetails();
    }
}