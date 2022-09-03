


degeral value = new degeral();
string[] s = value.deger();

string metin = s[0];
int sayi = Convert.ToInt32(s[1]);

Console.WriteLine(metin.Remove(sayi,1));


public class degeral
{
    public string[] deger()
    {
        try
        {   
            Console.Write("Aralarında sadece virgül bırakarak metni ve indeksi giriniz: ");
            string[] s = Console.ReadLine().Split(',');

            string metin = s[0];
            int index = Convert.ToInt32(s[1]);

            return s;
        
        }
        catch(Exception)
        {
            Console.WriteLine("Değerleri doğru giriniz! (Example => Algoritma,3) ");
            return deger();            
        }
    
    }

} 















