
Console.WriteLine("Kelimeleri giriniz: ");            
string[] Array = Console.ReadLine().Split();
KelimeKontrol(Array);
Console.ReadLine();


static void KelimeKontrol(string[] array)
{
    foreach (var item in array)
    {
        bool def = false;
        for (int i = 1; i < item.Length; i++)
        {
            if (harfKontrol(item[i]) == harfKontrol(item[i - 1]))
                def = true;
        }
        Console.Write(def + " ");
    }

    bool harfKontrol(char c)
    {
        return !"aeıioöuü".ToCharArray().Contains(c);
    }

}
