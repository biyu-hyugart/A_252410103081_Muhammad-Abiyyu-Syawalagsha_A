using System;

class Sekolah
{
    public string idSekolah;
    public string namaSekolah;
    public int jumlahPaketDiterima;

    public void Tampilkan(string idSekolah, string namaSekolah, int jumlahPaketDiterima)
    {
        Console.WriteLine($" Informasi Sekolah ");
        Console.WriteLine($" id sekolah = {idSekolah}");
        Console.WriteLine($" nama sekolah = {namaSekolah} ");
        Console.WriteLine($" jumlah paket yang di terima = {jumlahPaketDiterima}");

    }
}

class PaketMBG
{
    private string idPaket;
    private string namaPaket;
    private int stokDapur;

    public void Tampilkanmbg(string idpaket, string namapaket, int stokdapur)
    {
        idPaket = idpaket;
        namaPaket = namapaket;
        stokDapur = stokdapur;

        Console.WriteLine($" id sekolah = {idPaket}");
        Console.WriteLine($" nama sekolah = {namaPaket} ");
        Console.WriteLine($" jumlah paket yang di terima = {stokDapur}");
    }
    public void KurangiStok(int jumlah)
    {
        int hasil = stokDapur - jumlah;
        stokDapur = hasil;
        if (stokDapur < 0)
        {
            Console.WriteLine(" stok dapur tidak boleh bernilai negatif!!!");
        }
        else
        {
            Console.WriteLine($" stok dapur {stokDapur}");
        }

    }
    
    public virtual void HitungBiaya(int jumlah)
    {

    }
}

class PaketReguler : PaketMBG 
{
    public int harga = 15000;
    public int jumlah;

    public virtual void isimakanan(string jenis)
    {
        Console.WriteLine($"Paket ini berisi nasi,ayam,sayur,dan buah.");
    }
    //public override void HitungBiaya(int jumlah)
    //{
    //    PaketReguler PaketReguler1 = new PaketReguler();
    //    PaketReguler1 = hitung * 15000;
    //}
}

class PaketKhusus : PaketMBG
{

    public int harga = 20000;
    public int jumlahpaket;
    public void jenisdiet(string makan)
    {

    }
    //public override void isimakanan( string jenis)
    //{
    //    Console.WriteLine($"jenis makanan yang kamu pilih = {jenis}");
    //}
    public override void HitungBiaya(int jumlah)
    {
        jumlahpaket = jumlah * harga;
    }
    //public override void HitungBiaya(int jumlah)
    //{
    //    PaketReguler PaketReguler2 = new PaketReguler();
    //    PaketReguler2 = Hitung * 20000;
    //}
}

abstract class paketMBG
{

}



class Program
{
    static void Main(string[] args)
    {
        Sekolah sekolah1 = new Sekolah();
        sekolah1.Tampilkan("001","sdJember",100);

        PaketMBG PaketMBG1 = new PaketMBG();
        PaketMBG1.Tampilkanmbg("001", "Paket Reguler", 200);
        {

        }
    }
}