using System.Resources;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string judul)
    {
        Random idRandom = new Random();
        this.id = idRandom.Next(0, 100000);

        this.title = judul;
        this.playCount = 0;
    }

    public void increasePlayCount(int playCount)
    {
        this.playCount = playCount;
    }

    public void printVideoDetails()
    {
        Console.WriteLine("Video " + title + " dengan ID " + id + " telah diputar sebanyak " + playCount + " Kali");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tutorial Design By Contract - KamalMaulaazkaSidhqi_Praktikan");
        SayaTubeVideo vid = new SayaTubeVideo("Ramadhan");
        vid.increasePlayCount(9);
        vid.printVideoDetails();
    }
}