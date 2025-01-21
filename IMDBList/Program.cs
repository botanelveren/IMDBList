using System;
using System.Collections.Generic;

class Film
{
    public double ImdbPuani { get; set; }
    public string Ismi { get; set; }

    public Film(double imdbPuani, string isim)
    {
        ImdbPuani = imdbPuani;
        Ismi = isim;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Film> filmler = new List<Film>();

        while (true)
        {
            Console.Write("Film ismi giriniz (Çıkmak için boş bırakın): ");
            string filmIsmi = Console.ReadLine();

            if (string.IsNullOrEmpty(filmIsmi))
                break;

            Console.Write("Film puanı giriniz: ");
            double imdbPuani = Convert.ToDouble(Console.ReadLine());

            Film yeniFilm = new Film(imdbPuani, filmIsmi);
            filmler.Add(yeniFilm);

            Console.WriteLine("Yeni film eklemek ister misiniz? (evet/hayır)");
            string cevap = Console.ReadLine().ToLower();
            if (cevap != "evet")
                break;
        }

        // Tüm filmleri listeleme
        Console.WriteLine("\nTüm Filmler:");
        foreach (var film in filmler)
        {
            Console.WriteLine($"Film Adı: {film.Ismi}, IMDB Puanı: {film.ImdbPuani}");
        }

        // IMDB puanı 4 ile 9 arasında olan filmler
        Console.WriteLine("\nIMDB Puanı 4-9 Arasındaki Filmler:");
        foreach (var film in filmler)
        {
            if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
            {
                Console.WriteLine($"Film Adı: {film.Ismi}, IMDB Puanı: {film.ImdbPuani}");
            }
        }

        // İsmi 'A' ile başlayan filmler
        Console.WriteLine("\nİsmi 'A' ile Başlayan Filmler:");
        foreach (var film in filmler)
        {
            if (film.Ismi.StartsWith("A"))
            {
                Console.WriteLine($"Film Adı: {film.Ismi}, IMDB Puanı: {film.ImdbPuani}");
            }
        }
    }
}