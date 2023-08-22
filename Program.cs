
namespace deneme
{

    class Program
    {
        static void Main(string[] args){

            Ogrenci ogr1 = new Ogrenci();

            ogr1.ogrenciNo = "123";
            ogr1.adSoyad = " hatay";
            ogr1.sube = "2a";

            Console.WriteLine($"{ogr1.ogrenciNo}numaralı ogrenci");
        }
    }
    class Ogrenci
    {
        public string ogrenciNo { get; set; }
        public string adSoyad { get; set; }
        public string sube { get; set; }
    }
}