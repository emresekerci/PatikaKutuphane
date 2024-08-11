

    public class Kitap  // Kitap adında bir sınıf (class) tanımlıyoruz. Sınıf, belirli bir nesnenin yapısını ve davranışlarını tanımlar.
{
    // Property: Sınıfın içindeki değişkenlerdir. Bir nesnenin durumunu temsil eder.
    private DateTime _kayitTarihi;
        public string Ad { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayinevi { get; set; }
        public DateTime KayitTarihi
        {
            get { return _kayitTarihi; }
            private set { _kayitTarihi = value; }
        }
    // Constructor: Sınıfın bir örneği (nesnesi) oluşturulurken çağrılan metot. Nesnenin başlangıç durumunu ayarlar.
    // Default Constructor
    public Kitap()
        {
            KayitTarihi = DateTime.Now; // Kayıt tarihi o anki tarih olarak atanır
        }

    // Parametreli Constructor: Nesne oluşturulurken verilen parametreler ile property'leri ayarlar.
    public Kitap(string ad, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinevi)
           
        {
            Ad = ad;
            YazarAdi = yazarAdi;
            YazarSoyadi = yazarSoyadi;
            SayfaSayisi = sayfaSayisi;
            Yayinevi = yayinevi;
        }

    //Kitap bilgilerini konsola yazdırır.
        public void KitapBilgileri()
        {
            Console.WriteLine($"Kitap Adı: {Ad}");
            Console.WriteLine($"Yazar Adı: {YazarAdi}");
            Console.WriteLine($"Yazar Soyadı: {YazarSoyadi}");
            Console.WriteLine($"Sayfa Sayısı: {SayfaSayisi}");
            Console.WriteLine($"Yayınevi: {Yayinevi}");
        Console.WriteLine($"Kayıt Tarihi: {KayitTarihi}");
    }
    }

