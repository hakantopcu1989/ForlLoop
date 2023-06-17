 
using System;

 namespace ForLoop
 {
     class Program
{
    static void Main(string[] args)
    {
        //ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
        Console.Write("Lütfen Bir sayı giriniz: ");
        int sayac=int.Parse(Console.ReadLine());
        for (int i = 0; i < sayac; i++)
        {
            if(i%2==1)
            Console.WriteLine(i);
           //komutlar
        }

        // 1 ile 1000 arasındaki çift sayıların kendi içlerindeki toplamlar
        int tekToplam=0;
        int ciftToplam=0;
        for (int i = 1; i <=1000 ; i++)
        {
            if(i%2==1)
            tekToplam+=i; //tektoplam=tektoplam+i
            else
            ciftToplam+=i; 
        }
        Console.WriteLine("Tek Toplam: " + tekToplam);
        Console.WriteLine("Çift Toplam: " + ciftToplam);

        // break,continue

        for (int i = 0; i < 10; i++)
        {
            if(i==4)
            break;
            Console.WriteLine(i);
        }
        
          for (int i = 0; i < 10; i++)
        {
            if(i==4)
            continue;
            Console.WriteLine(i);
        }

    }
}
 }
