using System;

namespace Patikaflix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>(); // creating the list of objects
            Console.WriteLine("dizi girmek için 'e', çıkmak için herhangi bir tuşa basınız...");
            string input = Console.ReadLine();
            while (input == "e")
            {
                Console.WriteLine("dizi adı");
                string name = Console.ReadLine().ToLower();
                Console.WriteLine("yapım yılı");
                int make = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dizi türü");
                string genre = Console.ReadLine();
                Console.WriteLine("çıkış yılı");
                int debut = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dizi yönetmeni");
                string producer = Console.ReadLine();
                Console.WriteLine("dizinin yayınlandığı platform");
                string platform = Console.ReadLine();
                Movie movie = new Movie(name, make, genre, debut, producer, platform);
                movies.Add(movie);
                Console.WriteLine("dizi girmek için 'e', çıkmak için herhangi bir tuşa basınız...");
                input = Console.ReadLine();
            }
            var sumMovies = movies.Select(a => new MovieSum()
            {
                Name = a.Name,
                Genre = a.Genre,
                Producer = a.Producer,
            }).ToList()
            .Where(x => x.Genre == "komedi")
            .OrderBy(a => a.Name)
            .ThenBy(a => a.Producer);

            Console.WriteLine("Oluşturulan alt dizi elemanları şu şekildedir:");
            foreach (MovieSum movie in sumMovies)
            {
                Console.WriteLine($"Dizi adı: {movie.Name} - Dizi Yönetmeni: {movie.Producer}");
            }
        }
    }
}