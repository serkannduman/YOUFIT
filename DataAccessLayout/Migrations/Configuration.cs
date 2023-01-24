namespace DataAccessLayout.Migrations
{
    using DataAccessLayout.Concrete;
    using DataAccessLayout.Context;
    using Entities.Concrete;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayout.Context.YouFitDbContext>
    {
        private readonly YouFitDbContext youFitDbContext;
        private readonly BesinKategorileriRepository _besinKategorileriRepository;
        private readonly BesinlerRepository _besinlerRepository;
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

            youFitDbContext = new YouFitDbContext();
            _besinKategorileriRepository = new BesinKategorileriRepository(youFitDbContext);
            _besinlerRepository = new BesinlerRepository(youFitDbContext);
        }

        protected override void Seed(DataAccessLayout.Context.YouFitDbContext context)
        {
            YouFitDbContext youFitDbContext = new YouFitDbContext();
            var sutUrun = new BesinKategorileri { KategoriAdi = "Süt Ürünleri" };
            var etUrun = new BesinKategorileri { KategoriAdi = "Et Ürünleri" };
            var sebze = new BesinKategorileri { KategoriAdi = "Sebze" };
            var meyve = new BesinKategorileri { KategoriAdi = "Meyve" };
            var tahilVeEkmekUrun = new BesinKategorileri { KategoriAdi = "Tahıl ve Ekmek Ürünleri" };
            var tatli = new BesinKategorileri { KategoriAdi = "Tatlı" };
            var icecek = new BesinKategorileri { KategoriAdi = "İçecek" };
            var balikUrun = new BesinKategorileri { KategoriAdi = "Balık Ürünleri" };
            var corba = new BesinKategorileri { KategoriAdi = "Çorbalar" };
            var sebzeYemek = new BesinKategorileri { KategoriAdi = "Sebze Yemekleri" };
            var salata = new BesinKategorileri { KategoriAdi = "Salatalar" };

            _besinKategorileriRepository.Add(sutUrun);
            _besinKategorileriRepository.Add(etUrun);
            _besinKategorileriRepository.Add(sebze);
            _besinKategorileriRepository.Add(meyve);
            _besinKategorileriRepository.Add(tahilVeEkmekUrun);
            _besinKategorileriRepository.Add(tatli);
            _besinKategorileriRepository.Add(icecek);
            _besinKategorileriRepository.Add(balikUrun);
            _besinKategorileriRepository.Add(corba);
            _besinKategorileriRepository.Add(sebzeYemek);
            _besinKategorileriRepository.Add(salata);





            var tamYagliInekSutu = new Besinler() { BesinAdi = "Tam Yağlı İnek Sütü", BesinKalori = 110, KategoriId = 1 };

            var yarimYagliInekSutu = new Besinler() { BesinAdi = "Yarım Yağlı İnek Sütü", BesinKalori = 92, KategoriId = 1 };

            var yagsizInekSutu = new Besinler() { BesinAdi = "Yağsız İnek Sütü", BesinKalori = 76, KategoriId = 1 };

            var keciSutu = new Besinler() { BesinAdi = "Keçi Sütü", BesinKalori = 124, KategoriId = 1 };

            var soyaSutu = new Besinler() { BesinAdi = "Soya Sütü", BesinKalori = 112, KategoriId = 1 };
            var ezinePeyniri = new Besinler() { BesinAdi = "Ezine Peyniri", BesinKalori = 100, KategoriId = 1 };
            var tulumPeyniri = new Besinler() { BesinAdi = "TulumPeyniri", BesinKalori = 98, KategoriId = 1 };
            var orguPeyniri = new Besinler() { BesinAdi = "Örgü Peyniri", BesinKalori = 71, KategoriId = 1 };
            var kasarPeyniri = new Besinler() { BesinAdi = "Kaşar Peyniri", BesinKalori = 106, KategoriId = 1 };
            var keciPeyniri = new Besinler() { BesinAdi = "Keçi Peyniri", BesinKalori = 66, KategoriId = 1 };
            var danaJambon = new Besinler() { BesinAdi = "Dana Jambon", BesinKalori = 106, KategoriId = 2 };
            var kavurma = new Besinler() { BesinAdi = "Kavurma", BesinKalori = 345, KategoriId = 2 };
            var pastirma = new Besinler() { BesinAdi = "Pastırma", BesinKalori = 250, KategoriId = 2 };
            var salam = new Besinler() { BesinAdi = "Salam", BesinKalori = 150, KategoriId = 2 };
            var sosis = new Besinler() { BesinAdi = "Sosis", BesinKalori = 150, KategoriId = 2 };
            var sucuk = new Besinler() { BesinAdi = "Sucuk", BesinKalori = 166, KategoriId = 2 };
            var tavuk = new Besinler() { BesinAdi = "Tavuk", BesinKalori = 186, KategoriId = 2 };
            var ordek = new Besinler() { BesinAdi = "Ordek", BesinKalori = 339, KategoriId = 2 };
            var kaz = new Besinler() { BesinAdi = "Kaz", BesinKalori = 371, KategoriId = 2 };
            var hindi = new Besinler() { BesinAdi = "Hindi", BesinKalori = 166, KategoriId = 2 };

            var alabalik = new Besinler() { BesinAdi = "Alabalık", BesinKalori = 175, KategoriId = 8 };
            var kalkan = new Besinler() { BesinAdi = "Kalkan", BesinKalori = 143, KategoriId = 8 };
            var kilic = new Besinler() { BesinAdi = "Kılıç", BesinKalori = 203, KategoriId = 8 };
            var levrek = new Besinler() { BesinAdi = "Levrek", BesinKalori = 291, KategoriId = 8 };
            var mersin = new Besinler() { BesinAdi = "Mersin", BesinKalori = 96, KategoriId = 8 };
            var palamut = new Besinler() { BesinAdi = "Palamut", BesinKalori = 324, KategoriId = 8 };
            var sardalya = new Besinler() { BesinAdi = "Sardalya", BesinKalori = 160, KategoriId = 8 };
            var somon = new Besinler() { BesinAdi = "Somon", BesinKalori = 358, KategoriId = 8 };
            var ton = new Besinler() { BesinAdi = "Ton Balığı", BesinKalori = 306, KategoriId = 8 };
            var uskumru = new Besinler() { BesinAdi = "Uskumru", BesinKalori = 205, KategoriId = 8 };
            var istakoz = new Besinler() { BesinAdi = "İstakoz", BesinKalori = 89, KategoriId = 8 };
            var domates = new Besinler() { BesinAdi = "Domates Çorbası", BesinKalori = 66, KategoriId = 9 };
            var ezogelin = new Besinler() { BesinAdi = "Ezogelin Çorbası", BesinKalori = 95, KategoriId = 9 };
            var iskembe = new Besinler() { BesinAdi = "İşkembe Çorbası", BesinKalori = 209, KategoriId = 9 };
            var tarhana = new Besinler() { BesinAdi = "Tarhana Çorbası", BesinKalori = 151, KategoriId = 9 };
            var sebzeCorbasi = new Besinler() { BesinAdi = "Sebze Çorbası", BesinKalori = 114, KategoriId = 9 };
            var yaylaCorbasi = new Besinler() { BesinAdi = "Yayla Çorbası", BesinKalori = 98, KategoriId = 9 };
            var sehriyeliTavukCorbasi = new Besinler() { BesinAdi = "Şehriyeli Tavuk Çorbası", BesinKalori = 252, KategoriId = 9 };
            var unCorbasi = new Besinler() { BesinAdi = "Un Çorbası", BesinKalori = 92, KategoriId = 9 };
            var balkabagiCorbasi = new Besinler() { BesinAdi = "Balkabağı Çorbası", BesinKalori = 122, KategoriId = 9 };
            var yulafozuCorbasi = new Besinler() { BesinAdi = "Yulafözü Çorbası", BesinKalori = 166, KategoriId = 9 };
            var bezelyeCorbasi = new Besinler() { BesinAdi = "Bezelye Çorbası", BesinKalori = 137, KategoriId = 9 };
            var bugdayekmegi = new Besinler() { BesinAdi = "Buğday Ekmeği", BesinKalori = 67, KategoriId = 5 };
            var cavdarEkmegi = new Besinler() { BesinAdi = "Çavdar Ekmeği", BesinKalori = 63, KategoriId = 5 };
            var kepekEkmegi = new Besinler() { BesinAdi = "Kepek Ekmeği", BesinKalori = 65, KategoriId = 5 };
            var makarna = new Besinler() { BesinAdi = "Makarna", BesinKalori = 173, KategoriId = 5 };
            var sandvicEkmegi = new Besinler() { BesinAdi = "Sandviç Ekmeği", BesinKalori = 178, KategoriId = 5 };
            var borek = new Besinler() { BesinAdi = "Börek", BesinKalori = 242, KategoriId = 5 };
            var ahududu = new Besinler() { BesinAdi = "Ahududu", BesinKalori = 57, KategoriId = 4 };
            var ananas = new Besinler() { BesinAdi = "Ananas", BesinKalori = 52, KategoriId = 4 };
            var armut = new Besinler() { BesinAdi = "Armut", BesinKalori = 61, KategoriId = 4 };
            var avokado = new Besinler() { BesinAdi = "Avokado", BesinKalori = 167, KategoriId = 4 };
            var ayva = new Besinler() { BesinAdi = "Ayva", BesinKalori = 57, KategoriId = 4 };
            var bogurtlen = new Besinler() { BesinAdi = "Böğürtlen", BesinKalori = 58, KategoriId = 4 };
            var cilek = new Besinler() { BesinAdi = "Çilek", BesinKalori = 37, KategoriId = 4 };
            var dut = new Besinler() { BesinAdi = "Dut", BesinKalori = 93, KategoriId = 4 };
            var elma = new Besinler() { BesinAdi = "Elma", BesinKalori = 58, KategoriId = 4 };
            var erik = new Besinler() { BesinAdi = "Erik", BesinKalori = 66, KategoriId = 4 };
            var greyfurt = new Besinler() { BesinAdi = "Greyfurt", BesinKalori = 41, KategoriId = 4 };
            var kuruIncir = new Besinler() { BesinAdi = "Kuru İncir", BesinKalori = 174, KategoriId = 4 };
            var kuruKayisi = new Besinler() { BesinAdi = "Kuru Kayısı", BesinKalori = 260, KategoriId = 4 };
            var karpuz = new Besinler() { BesinAdi = "Karpuz", BesinKalori = 26, KategoriId = 4 };
            var kavun = new Besinler() { BesinAdi = "Kavun", BesinKalori = 33, KategoriId = 4 };
            var kiraz = new Besinler() { BesinAdi = "Kiraz", BesinKalori = 63, KategoriId = 4 };
            var kivi = new Besinler() { BesinAdi = "Kivi", BesinKalori = 30, KategoriId = 4 };
            var limon = new Besinler() { BesinAdi = "Limon", BesinKalori = 27, KategoriId = 4 };
            var mandalina = new Besinler() { BesinAdi = "Mandalina", BesinKalori = 46, KategoriId = 4 };
            var muz = new Besinler() { BesinAdi = "Muz", BesinKalori = 105, KategoriId = 4 };
            var nar = new Besinler() { BesinAdi = "Nar", BesinKalori = 63, KategoriId = 4 };
            var portakal = new Besinler() { BesinAdi = "Portakal", BesinKalori = 49, KategoriId = 4 };
            var seftali = new Besinler() { BesinAdi = "Şeftali", BesinKalori = 38, KategoriId = 4 };
            var uzum = new Besinler() { BesinAdi = "Üzüm", BesinKalori = 67, KategoriId = 4 };
            var visne = new Besinler() { BesinAdi = "Vişne", BesinKalori = 58, KategoriId = 4 };
            var sutlac = new Besinler() { BesinAdi = "Sütlaç", BesinKalori = 268, KategoriId = 6 };
            var fırınSutlac = new Besinler() { BesinAdi = "Fırın Sütlaç", BesinKalori = 286, KategoriId = 6 };
            var halkaTatlisi = new Besinler() { BesinAdi = "Halka Tatlısı", BesinKalori = 263, KategoriId = 6 };
            var tavukgogsu = new Besinler() { BesinAdi = "Tavukgöğsü", BesinKalori = 165, KategoriId = 6 };
            var profiterol = new Besinler() { BesinAdi = "Profiterol", BesinKalori = 429, KategoriId = 6 };
            var fistikliTelKadayif = new Besinler() { BesinAdi = "Fıstıklı Tel Kadayıf", BesinKalori = 382, KategoriId = 6 };
            var baklava = new Besinler() { BesinAdi = "Baklava", BesinKalori = 659, KategoriId = 6 };
            var muhallebi = new Besinler() { BesinAdi = "Muhallebi", BesinKalori = 233, KategoriId = 6 };
            var helva = new Besinler() { BesinAdi = "Helva", BesinKalori = 190, KategoriId = 6 };
            var sekerpare = new Besinler() { BesinAdi = "Şekerpare", BesinKalori = 544, KategoriId = 6 };
            var kazandibi = new Besinler() { BesinAdi = "Kazandibi", BesinKalori = 201, KategoriId = 6 };
            var aşure = new Besinler() { BesinAdi = "Aşure", BesinKalori = 244, KategoriId = 6 };

            //--------İÇECEK----------------
            var bira = new Besinler() { BesinAdi = "Bira", BesinKalori = 84, KategoriId = 7 };
            var sarap = new Besinler() { BesinAdi = "Şarap", BesinKalori = 74, KategoriId = 7 };
            var kola = new Besinler() { BesinAdi = "Kola", BesinKalori = 122, KategoriId = 7 };
            var fanta = new Besinler() { BesinAdi = "Fanta", BesinKalori = 95, KategoriId = 7 };
            var sekerliCay = new Besinler() { BesinAdi = "Şekerli Çay", BesinKalori = 21, KategoriId = 7 };
            var ayran = new Besinler() { BesinAdi = "Ayran", BesinKalori = 75, KategoriId = 7 };

            var meyveSuyu = new Besinler() { BesinAdi = "Meyve Suyu", BesinKalori = 100, KategoriId = 7 };
            var salgamSuyu = new Besinler() { BesinAdi = "Şalgam Suyu", BesinKalori = 10, KategoriId = 7 };
            var vodka = new Besinler() { BesinAdi = "Vodka Suyu", BesinKalori = 232, KategoriId = 7 };
            var raki = new Besinler() { BesinAdi = "Rakı", BesinKalori = 200, KategoriId = 7 };
            var gazoz = new Besinler() { BesinAdi = "Gazoz", BesinKalori = 190, KategoriId = 7 };
            var sutluKahve = new Besinler() { BesinAdi = "Sütlü Kahve", BesinKalori = 71, KategoriId = 7 };

            //------SEBZELER-------------------

            var patates = new Besinler() { BesinAdi = "Patates", BesinKalori = 77, KategoriId = 3 };
            var marul = new Besinler() { BesinAdi = "Marul", BesinKalori = 16, KategoriId = 3 };
            var roka = new Besinler() { BesinAdi = "Roka", BesinKalori = 25, KategoriId = 3 };
            var ıspanak = new Besinler() { BesinAdi = "Ispanak", BesinKalori = 19, KategoriId = 3 };
            var patlican = new Besinler() { BesinAdi = "Patlıcan", BesinKalori = 17, KategoriId = 3 };
            var salatalik = new Besinler() { BesinAdi = "Salatalık", BesinKalori = 18, KategoriId = 3 };
            var morLahana = new Besinler() { BesinAdi = "Mor Lahana", BesinKalori = 54, KategoriId = 3 };
            var kereviz = new Besinler() { BesinAdi = "Mor Lahana", BesinKalori = 42, KategoriId = 3 };
            var brokoli = new Besinler() { BesinAdi = "Brokoli", BesinKalori = 39, KategoriId = 3 };
            var yesilSogan = new Besinler() { BesinAdi = "Yeşil Soğan", BesinKalori = 15, KategoriId = 3 };
            var tazeFasulye = new Besinler() { BesinAdi = "Taze Fasulye", BesinKalori = 47, KategoriId = 3 };
            var pırasa = new Besinler() { BesinAdi = "Pırasa", BesinKalori = 92, KategoriId = 3 };
            var dereotu = new Besinler() { BesinAdi = "Dereotu", BesinKalori = 7, KategoriId = 3 };
            var kırmızıTurp = new Besinler() { BesinAdi = "Kırmızı Turp", BesinKalori = 16, KategoriId = 3 };
            var beyazTurp = new Besinler() { BesinAdi = "Beyaz Turp", BesinKalori = 21, KategoriId = 3 };
            var karnabahar = new Besinler() { BesinAdi = "Karnabahar", BesinKalori = 38, KategoriId = 3 };
            var kuskonmaz = new Besinler() { BesinAdi = "Kuşkonmaz", BesinKalori = 33, KategoriId = 3 };
            var enginar = new Besinler() { BesinAdi = "Enginar", BesinKalori = 71, KategoriId = 3 };
            var semizotu = new Besinler() { BesinAdi = "Semizotu", BesinKalori = 27, KategoriId = 3 };
            var kabak = new Besinler() { BesinAdi = "Kabak", BesinKalori = 29, KategoriId = 3 };
            var havuç = new Besinler() { BesinAdi = "Havuç", BesinKalori = 55, KategoriId = 3 };

            //----sebze yemekleri-------

            var ıspanakYemegiPirinc = new Besinler() { BesinAdi = "Pirinçli Ispanak Yemeği", BesinKalori = 115, KategoriId = 10 };
            var ıspanakYemegiEtli = new Besinler() { BesinAdi = "Etli Ispanak Yemeği", BesinKalori = 145, KategoriId = 10 };
            var zeytinyagliSemizotu = new Besinler() { BesinAdi = "Zeytinyağlı Semizotu", BesinKalori = 112, KategoriId = 10 };
            var etliSemizotu = new Besinler() { BesinAdi = "Etli Semizotu", BesinKalori = 142, KategoriId = 10 };
            var zeytinyagliTazeFasulye = new Besinler() { BesinAdi = "Zeytinyağlı Taze Fasulye", BesinKalori = 151, KategoriId = 10 };
            var etliTazeFasulye = new Besinler() { BesinAdi = "Etli Taze Fasulye", BesinKalori = 181, KategoriId = 10 };
            var zeytinyagliPirasa = new Besinler() { BesinAdi = "Zeytinyağlı Pırasa", BesinKalori = 120, KategoriId = 10 };
            var zeytinyagliBezelye = new Besinler() { BesinAdi = "Zeytinyağlı Bezelye", BesinKalori = 147, KategoriId = 10 };
            var etliBezelye = new Besinler() { BesinAdi = "Etli Bezelye Yemeği", BesinKalori = 177, KategoriId = 10 };
            var zeytinyagliBrokoli = new Besinler() { BesinAdi = "Zeytinyağlı Brokoli Yemeği", BesinKalori = 80, KategoriId = 10 };
            var etliliBrokoli = new Besinler() { BesinAdi = "Etli Brokoli Yemeği", BesinKalori = 110, KategoriId = 10 };
            var zeytinyagliKarnabahar = new Besinler() { BesinAdi = "Zeytinyağlı Karnabahar Yemeği", BesinKalori = 115, KategoriId = 10 };
            var etliKarnabahar = new Besinler() { BesinAdi = "Etli Karnabahar Yemeği", BesinKalori = 144, KategoriId = 10 };
            var zeytinyagliBamya = new Besinler() { BesinAdi = "Zeytinyağlı Bamya Yemeği", BesinKalori = 113, KategoriId = 10 };
            var etliBamya = new Besinler() { BesinAdi = "Etli Bamya Yemeği", BesinKalori = 143, KategoriId = 11 };
            var zeytinyagliTurlu = new Besinler() { BesinAdi = "Zeytinyağlı Türlü Yemeği", BesinKalori = 112, KategoriId = 10 };
            var etliTurlu = new Besinler() { BesinAdi = "Etli Türlü Yemeği", BesinKalori = 142, KategoriId = 10 };
            var zeytinyagliKereviz = new Besinler() { BesinAdi = "Zeytinyağlı Kereviz", BesinKalori = 90, KategoriId = 10 };
            var zeytinyagliEnginar = new Besinler() { BesinAdi = "Zeytinyağlı Enginar", BesinKalori = 146, KategoriId = 10 };
            var sebzeSote = new Besinler() { BesinAdi = "Sebze Sote", BesinKalori = 90, KategoriId = 10 };
            var zeytinyagliYaprakSarma = new Besinler() { BesinAdi = "Zeytinyağlı Yaprak Sarma", BesinKalori = 108, KategoriId = 10 };
            var zeytinyagliKabak = new Besinler() { BesinAdi = "Zeytinyağlı Kabak Yemeği", BesinKalori = 111, KategoriId = 10 };
            var etliKabak = new Besinler() { BesinAdi = "Etli Kabak Yemeği", BesinKalori = 140, KategoriId = 10 };
            var mercimekYemegi = new Besinler() { BesinAdi = "Mercimek Yemeği", BesinKalori = 100, KategoriId = 10 };
            var nohutYemegi = new Besinler() { BesinAdi = "Nohut Yemeği", BesinKalori = 101, KategoriId = 10 };
            var kuruFasulye = new Besinler() { BesinAdi = "Kuru Fasulye", BesinKalori = 178, KategoriId = 10 };
            var zeytinyagliBarbunya = new Besinler() { BesinAdi = "Zeytinyağlı Barbunya", BesinKalori = 101, KategoriId = 10 };
            var bulgurPilavi = new Besinler() { BesinAdi = "Bulgur Pilavı", BesinKalori = 133, KategoriId = 10 };

            var pirincPilavi = new Besinler() { BesinAdi = "Pirinç Pilavı", BesinKalori = 175, KategoriId = 10 };
            var sehriyePilavi = new Besinler() { BesinAdi = "Şehriye Pilavı", BesinKalori = 77, KategoriId = 10 };

            //--------salatalar---------
            var sadeSalata = new Besinler() { BesinAdi = "Sade Salata", BesinKalori = 9, KategoriId = 11 };
            var tavukluSalata = new Besinler() { BesinAdi = "Tavuklu Salata", BesinKalori = 255, KategoriId = 11 };
            var etliSalata = new Besinler() { BesinAdi = "Etli Salata", BesinKalori = 267, KategoriId = 11 };
            var tonBalikliSalata = new Besinler() { BesinAdi = "Ton Balıklı Salata", BesinKalori = 215, KategoriId = 11 };
            var kisir = new Besinler() { BesinAdi = "Kısır", BesinKalori = 108, KategoriId = 11 };
            var cobanSalata = new Besinler() { BesinAdi = "Çoban Salata", BesinKalori = 120, KategoriId = 11 };
            var gevurdagiSalata = new Besinler() { BesinAdi = "Gevurdağı Salata", BesinKalori = 115, KategoriId = 11 };
            var mevsimSalata = new Besinler() { BesinAdi = "Mevsim Salata", BesinKalori = 59, KategoriId = 11 };



            _besinlerRepository.Add(tamYagliInekSutu);
            _besinlerRepository.Add(yarimYagliInekSutu);
            _besinlerRepository.Add(yagsizInekSutu);
            _besinlerRepository.Add(keciSutu);
            _besinlerRepository.Add(soyaSutu);
            _besinlerRepository.Add(ezinePeyniri);
            _besinlerRepository.Add(tulumPeyniri);
            _besinlerRepository.Add(orguPeyniri);
            _besinlerRepository.Add(kasarPeyniri);
            _besinlerRepository.Add(keciPeyniri);
            _besinlerRepository.Add(danaJambon);
            _besinlerRepository.Add(kavurma);
            _besinlerRepository.Add(pastirma);
            _besinlerRepository.Add(salam);
            _besinlerRepository.Add(sosis);
            _besinlerRepository.Add(sucuk);
            _besinlerRepository.Add(tavuk);
            _besinlerRepository.Add(ordek);
            _besinlerRepository.Add(kaz);
            _besinlerRepository.Add(hindi);
            _besinlerRepository.Add(alabalik);
            _besinlerRepository.Add(kalkan);
            _besinlerRepository.Add(kilic);
            _besinlerRepository.Add(levrek);
            _besinlerRepository.Add(mersin);
            _besinlerRepository.Add(palamut);
            _besinlerRepository.Add(sardalya);
            _besinlerRepository.Add(somon);
            _besinlerRepository.Add(ton);
            _besinlerRepository.Add(uskumru);
            _besinlerRepository.Add(istakoz);
            _besinlerRepository.Add(domates);
            _besinlerRepository.Add(ezogelin);
            _besinlerRepository.Add(iskembe);
            _besinlerRepository.Add(tarhana);
            _besinlerRepository.Add(sebzeCorbasi);
            _besinlerRepository.Add(yaylaCorbasi);
            _besinlerRepository.Add(sehriyeliTavukCorbasi);
            _besinlerRepository.Add(unCorbasi);
            _besinlerRepository.Add(balkabagiCorbasi);
            _besinlerRepository.Add(yulafozuCorbasi);
            _besinlerRepository.Add(bezelyeCorbasi);
            _besinlerRepository.Add(bugdayekmegi);
            _besinlerRepository.Add(cavdarEkmegi);
            _besinlerRepository.Add(kepekEkmegi);
            _besinlerRepository.Add(makarna);
            _besinlerRepository.Add(sandvicEkmegi);
            _besinlerRepository.Add(borek);
            _besinlerRepository.Add(ahududu);
            _besinlerRepository.Add(ananas);
            _besinlerRepository.Add(armut);
            _besinlerRepository.Add(avokado);
            _besinlerRepository.Add(ayva);
            _besinlerRepository.Add(bogurtlen);
            _besinlerRepository.Add(cilek);
            _besinlerRepository.Add(dut);
            _besinlerRepository.Add(elma);
            _besinlerRepository.Add(erik);
            _besinlerRepository.Add(greyfurt);
            _besinlerRepository.Add(kuruIncir);
            _besinlerRepository.Add(kuruKayisi);
            _besinlerRepository.Add(karpuz);
            _besinlerRepository.Add(kavun);
            _besinlerRepository.Add(kiraz);
            _besinlerRepository.Add(kivi);
            _besinlerRepository.Add(limon);
            _besinlerRepository.Add(mandalina);
            _besinlerRepository.Add(muz);
            _besinlerRepository.Add(nar);
            _besinlerRepository.Add(portakal);
            _besinlerRepository.Add(seftali);
            _besinlerRepository.Add(uzum);
            _besinlerRepository.Add(visne);
            _besinlerRepository.Add(sutlac);
            _besinlerRepository.Add(fırınSutlac);
            _besinlerRepository.Add(halkaTatlisi);
            _besinlerRepository.Add(tavukgogsu);
            _besinlerRepository.Add(profiterol);
            _besinlerRepository.Add(fistikliTelKadayif);
            _besinlerRepository.Add(baklava);
            _besinlerRepository.Add(muhallebi);
            _besinlerRepository.Add(helva);
            _besinlerRepository.Add(sekerpare);
            _besinlerRepository.Add(kazandibi);
            _besinlerRepository.Add(aşure);
            _besinlerRepository.Add(bira);
            _besinlerRepository.Add(sarap);
            _besinlerRepository.Add(kola);
            _besinlerRepository.Add(fanta);
            _besinlerRepository.Add(sekerliCay);
            _besinlerRepository.Add(ayran);
            _besinlerRepository.Add(meyveSuyu);
            _besinlerRepository.Add(salgamSuyu);
            _besinlerRepository.Add(vodka);
            _besinlerRepository.Add(raki);
            _besinlerRepository.Add(gazoz);
            _besinlerRepository.Add(sutluKahve);
            _besinlerRepository.Add(patates);
            _besinlerRepository.Add(marul);
            _besinlerRepository.Add(roka);
            _besinlerRepository.Add(ıspanak);
            _besinlerRepository.Add(patlican);
            _besinlerRepository.Add(salatalik);
            _besinlerRepository.Add(morLahana);
            _besinlerRepository.Add(kereviz);
            _besinlerRepository.Add(brokoli);
            _besinlerRepository.Add(yesilSogan);
            _besinlerRepository.Add(tazeFasulye);
            _besinlerRepository.Add(pırasa);
            _besinlerRepository.Add(dereotu);
            _besinlerRepository.Add(kırmızıTurp);
            _besinlerRepository.Add(beyazTurp);
            _besinlerRepository.Add(karnabahar);
            _besinlerRepository.Add(kuskonmaz);
            _besinlerRepository.Add(enginar);
            _besinlerRepository.Add(semizotu);
            _besinlerRepository.Add(kabak);
            _besinlerRepository.Add(havuç);
            _besinlerRepository.Add(ıspanakYemegiPirinc);
            _besinlerRepository.Add(ıspanakYemegiEtli);
            _besinlerRepository.Add(zeytinyagliSemizotu);
            _besinlerRepository.Add(etliSemizotu);
            _besinlerRepository.Add(zeytinyagliTazeFasulye);
            _besinlerRepository.Add(etliTazeFasulye);
            _besinlerRepository.Add(zeytinyagliPirasa);
            _besinlerRepository.Add(zeytinyagliBezelye);
            _besinlerRepository.Add(etliBezelye);
            _besinlerRepository.Add(zeytinyagliBrokoli);
            _besinlerRepository.Add(etliliBrokoli);
            _besinlerRepository.Add(zeytinyagliKarnabahar);
            _besinlerRepository.Add(etliKarnabahar);
            _besinlerRepository.Add(zeytinyagliBamya);
            _besinlerRepository.Add(etliBamya);
            _besinlerRepository.Add(zeytinyagliTurlu);
            _besinlerRepository.Add(etliTurlu);
            _besinlerRepository.Add(zeytinyagliKereviz);
            _besinlerRepository.Add(zeytinyagliEnginar);
            _besinlerRepository.Add(sebzeSote);
            _besinlerRepository.Add(zeytinyagliYaprakSarma);
            _besinlerRepository.Add(zeytinyagliKabak);
            _besinlerRepository.Add(etliKabak);
            _besinlerRepository.Add(mercimekYemegi);
            _besinlerRepository.Add(nohutYemegi);
            _besinlerRepository.Add(kuruFasulye);
            _besinlerRepository.Add(zeytinyagliBarbunya);
            _besinlerRepository.Add(bulgurPilavi);
            _besinlerRepository.Add(pirincPilavi);
            _besinlerRepository.Add(sehriyePilavi);
            _besinlerRepository.Add(sadeSalata);
            _besinlerRepository.Add(tavukluSalata);
            _besinlerRepository.Add(etliSalata);
            _besinlerRepository.Add(tonBalikliSalata);
            _besinlerRepository.Add(kisir);
            _besinlerRepository.Add(cobanSalata);
            _besinlerRepository.Add(gevurdagiSalata);
            _besinlerRepository.Add(mevsimSalata);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
