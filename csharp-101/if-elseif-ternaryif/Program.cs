namespace if_elseif_ternaryif;
class Program
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;

        if(time >= 6 && time < 11 )
        Console.WriteLine("Günaydın");

        else if(time <= 18)
        Console.WriteLine("İyi günler");

        else
        Console.WriteLine("İyi geceler");


        //Ternary struct example
        string sonuc = time <= 18 ? "İyi günler" : "İyi geceler";

        //Ternary inside Ternary. Different version of above the code
        sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi günler" : "İyi geceler";

        Console.WriteLine(sonuc); 
    }
}
