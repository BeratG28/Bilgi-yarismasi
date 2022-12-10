namespace PROJE;
class Program
{
    static void Main(string[] args)
    {
        int soru = 1;
        string cevap;
        
        if (soru == 1) 
        {
          Console.WriteLine("Turkiyenin baskenti neresidir?");
          Console.WriteLine();
          Console.WriteLine("A)Istanbul");
          Console.WriteLine("B)Adana");
          Console.WriteLine("C)Ankara");
          Console.WriteLine("D)Bursa");
          Console.WriteLine();
          Console.Write("Cevabınız: ");
          cevap = Console.ReadLine();
        }  
         Console.Write("Cevap yanlış toplam puanınız: 0");
          
          Console.WriteLine("Cumhuriyet kaç yılında ilan edildi ?");
          Console.WriteLine();
          Console.WriteLine("A)1872");
          Console.WriteLine("B)1987");
          Console.WriteLine("C)1967");
          Console.WriteLine("D)1923");
          Console.WriteLine();
          Console.Write("Cevabınız: ");
          cevap=Console.ReadLine();
          if(cevap==d || cevap==D) 
          {
            Console.WriteLine("Tebrikler, yarışma sona erdi. Bütün soruları doğru bildiniz.");
            else
            {
                Console.WriteLine("Cevabınız yanlış, yarışma sona erdi. Toplam puanınız:2 ");
            }
          }
         



          

        }
        
    }
