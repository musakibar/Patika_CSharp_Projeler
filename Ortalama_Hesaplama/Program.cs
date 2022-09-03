

Console.WriteLine("Fibonacci Dizisi için eleman sayısı giriniz");
int sayi = int.Parse(Console.ReadLine());
Fibo(sayi);


static void Fibo (int sayi)
{
    int x = 0;
    int y = 1;
    Console.Write(x + " " + y + " ");

    for(int i = 2; i<sayi; i++)
    {
        int z = x + y;
        Console.Write(z + " ");
        x = y;
        y = z;

    }

}
