
Console.Write("Cümlenizi Giriniz: ");
string[] s = Console.ReadLine().Split(' ');
Console.WriteLine("");

for(int i = 0; i<s.Length; i++)
{
    string t = s[i];
    string yeni = "";
    string harf = "";
    for(int i2 = 0; i2<t.Length-1; i2++)
    {        
        harf = t[i2+1].ToString();
        yeni += harf; 
    }
        yeni += t[0].ToString();
        Console.Write(yeni + " ");
}
