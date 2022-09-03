
Console.Write("Cümlenizi Giriniz: ");
string[] s = Console.ReadLine().Split(' ');
Console.WriteLine("");

for(int i = 0; i<s.Length; i++)
{
    string t = s[i];
    string yeni = "";
    string ilkharf = "";

    for(int i2 = 0; i2<t.Length; i2++)
    {        
        if(i2==0)
        {   
            yeni += t[t.Length-1].ToString();
            ilkharf = t[i2].ToString();
        }
        else if(i2 == t.Length-1)
        {
            yeni += ilkharf;
        }
        else
        {
            yeni += t[i2].ToString();
        }
    }
        
        Console.Write(yeni + " ");
}