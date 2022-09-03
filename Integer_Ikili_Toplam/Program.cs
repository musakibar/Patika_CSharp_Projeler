

metot();

void metot()
{
    Console.WriteLine("Aralarında boşluk bırakarak çift adet sayi giriniz: ");
    string[] s = Console.ReadLine().Split(' ');
    if(s.Length % 2 == 1)
    {
        Console.WriteLine("Çift adet sayı girmediniz!  Tekrar Deneyin");
        metot();
    }

    islem(s);
}


void islem(string[] s)
{
    for(int i = 0; i<s.Length-1; i=i+2)
    {
        int deger1 = int.Parse(s[i]);
        int deger2 = int.Parse(s[i+1]);

        if(deger1 == deger2)
        {
            Console.Write(Math.Pow(deger1+deger2, 2) + " ");
        }
        else
        {
            Console.Write(deger1 + deger2 + " ");
        }
    }

}

