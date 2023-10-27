using System.Diagnostics;

namespace While_Foreach;

class Program
{
    static void Main(string[] args)
    //1den başlayarak consoleden girilen sayıya kadar(sayı dahil) ortalama hesaplayıp consolea yazdıran program
    {
       // Console.WriteLine("Lütfen bir sayi giriniz!");
       // int sayi = int.Parse(Console.ReadLine());
       // int sayac = 1;
       // int toplam = 0;
       // while (sayac<= sayi)
       // {
       //   toplam+= sayac;
       //   sayac ++;
       // }
       // Console.WriteLine(toplam/sayac);
        Console.WriteLine("Lütfen bir sayi giriniz");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        int basamak = 0;
        while (sayi1 > 0)
        {
            basamak++;
            sayi1 = sayi1 / 10;
        }
        Console.WriteLine("Girdiğiniz sayi"+ basamak.ToString()+ "basamaklidir");

    }

    
}
