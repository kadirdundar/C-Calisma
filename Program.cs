string deneme = "kadirin deneme stringi";
var istrue = deneme.Contains("k");
if (istrue == true)
{
    Console.WriteLine("calisti");
}


int[] yenidizi = {1,2,3,563,2};
Console.WriteLine(yenidizi[1]) ;

string[] yazimdizisi = {"kadir", "ali", "veli"};
Array.Sort(yazimdizisi);
Console.WriteLine(yazimdizisi.Length);

Console.WriteLine(yazimdizisi[0]);

int[] soruDizisi = {1,2,3,423,43,5};

foreach ( var item in soruDizisi)
{
Console.WriteLine(item);
}

namespace deneme
{

    class Program
    {
        static void Main(string[] args){

            Ogrenci ogr1 = new Ogrenci();

            ogr1.ogrenciNo = "123";
            ogr1.adSoyad = " hatay";
            ogr1.sube = "2a";

            Console.WriteLine(ogr1.PrintInformation());
        }
    }
    class Ogrenci
    {
        public string ogrenciNo { get; set; }// nesneye özel değil doğrudan sınıf üzerinden çağırılan bir metod yazmak için static kullanılır.
        public string adSoyad { get; set; }
        public string sube { get; set; }

        //methods
        public string PrintInformation(){
            return $"{this.ogrenciNo}numaralı ogrenci" ;  // this: o an erişilen nesne
        }
    }
}