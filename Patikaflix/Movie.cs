using System;

public class Movie
{
    public string Name { get; set; }
    public int Make { get; set; }
    public string Genre { get; set; }
    public int Debut { get; set; }
    public string Producer { get; set; }
    public string Platform { get; set; }
    public Movie(string name, int make, string genre, int debut, string producer, string platform)
    {
        Name = name;
        Make = make;
        Genre = genre;
        Debut = debut;
        Producer = producer;
        Platform = platform;
    }
}