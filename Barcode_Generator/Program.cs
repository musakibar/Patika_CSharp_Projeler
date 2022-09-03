using BarcodeApp;

BarcodeManager barcodeManager = new BarcodeManager();

Console.WriteLine("BarcodeGenarator/Scanner uygulamasına hoşgeldiniz. " +
    "Lütfen yapmak istediğiniz işlemi seçiniz.");
Console.WriteLine("1) Barkod oluşturma");
Console.WriteLine("2) Barkod okuma");

string secim = Console.ReadLine();

switch (secim)
{
    case "1":

        Console.WriteLine("Lütfen barkod görüntüsünü oluşturmak istediğiniz barkodun " +
        "sayısal bilgilerini giriniz (Örnek: 0123456789123)");
        string numericString = Console.ReadLine();
        barcodeManager.GenerateBarcode(numericString);
        break;

    case "2":

        Console.WriteLine(" Lütfen barkod görüntüsünü oluşturmak istediğiniz barkodun " +
            "bilgisayarınızdaki dosya yolunu giriniz. Örnek (C:\\Users\\*******\\Desktop\\Barcode.png)");
        barcodeManager.ReadBarcode(Console.ReadLine());
        break;
}

Console.ReadLine();