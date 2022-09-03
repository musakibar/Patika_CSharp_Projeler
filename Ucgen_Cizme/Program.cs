


try
{
    Console.Write("Üçgen boyutunu giriniz: ");
    int boyut = int.Parse(Console.ReadLine());
    Ciz(boyut);
}

catch(Exception)
{
    Console.WriteLine("Lütfen sayı giriniz.");

}


static void Ciz (int boyut)
{
    for(int x = 1; x<=boyut; x++)
    {
        for(int y=boyut; y>x; y--)
        {
            Console.Write(" ");
        }

        for(int z = 1; z<=x; z++)
        {
            Console.Write("* ");
        }

        Console.WriteLine("");

    }   

}