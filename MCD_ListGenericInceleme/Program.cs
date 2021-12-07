using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ListGenericInceleme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilarim = new List<int>();
            sayilarim.Add(1);

            int[] eklenecekData1 = new int[4];
            eklenecekData1[0] = 2;
            eklenecekData1[1] = 3;
            eklenecekData1[2] = 4;
            eklenecekData1[3] = 5;

            //1.yol ama uzun bir yol : 
            /*foreach (int item in eklenecekData1)
            {
                sayilarim.Add(item);
            }*/
            //2.yol :
            sayilarim.AddRange(eklenecekData1);

            //---------------------------------------------

            //int capacity = sayilarim.Capacity;
            //int count = sayilarim.Count;

            sayilarim.TrimExcess();// Count ve Capacity değerlerini eşitler

            int capacity = sayilarim.Capacity;
            int count = sayilarim.Count;

            //Soru : Sayılarım koleksiyonu içerisinde bulunan daayı ekrana yazdırmak istiyorum. Bunu nasıl yaparsınız?
            sayilarim.ForEach(i => Console.WriteLine(i));
            //sayilarim.ForEach(Console.WriteLine);

            // => ilgili koleksiyon içinde arama yap
            // => linq konusu List<T> içerisinde

            int bulunanDeger = sayilarim[3];
            Console.WriteLine("List<T> koleksiyonu içerisinde 3 numaralı indexte bulunan değer : " + bulunanDeger);

            sayilarim.Insert(3, 100);

            bool kontrol1 = sayilarim.Any();
            bool kontrol2 = sayilarim.Any(i => i > 5);

            sayilarim.Sort();//A-Z
            sayilarim.Reverse();//Z-A

            int enYuksekDeger = sayilarim.Max();
            int enDusukDeger = sayilarim.Min();
            int toplamDeger = sayilarim.Sum();

            //Uygulama alanı bir sonraki bölümde daha detaylı görülecek.
            //List<T> Uygulama - Windows Form

            bool silmeIslemiSonuc = sayilarim.Remove(100);
            int silinenAdet = sayilarim.RemoveAll(i => i > 3);
            sayilarim.RemoveAt(2);

            sayilarim.Sort();
            sayilarim.Reverse();

            sayilarim.Clear();
        }
    }
}
