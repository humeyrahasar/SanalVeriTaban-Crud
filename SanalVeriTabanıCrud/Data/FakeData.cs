using SanalVeriTabanıCrud.Models;
using System.Collections.Generic;

namespace SanalVeriTabanıCrud.Data
{
    public class FakeData
    {
        public List<Personel> Personels = new List<Personel>
        {
            new Personel {SicilNo = 1531, Adi = "Ahmet", Soyadi = "Hasar", Resim = "ahmet.jpg"},
            new Personel {SicilNo = 1532, Adi = "Mehmet", Soyadi = "Çalışır", Resim = "mehmet.jpg"},
            new Personel {SicilNo = 1533, Adi = "Ayşe", Soyadi = "Tok", Resim = "ayse.jpg"},
            new Personel {SicilNo = 1534, Adi = "Ali", Soyadi = "Yıldız", Resim = "ali.jpg"},
            new Personel {SicilNo = 1535, Adi = "Fatma", Soyadi = "Çeçen", Resim = "fatma.jpg"},
            new Personel {SicilNo = 1536, Adi = "Elif", Soyadi = "Çevik", Resim = "elif.jpg"},
            new Personel {SicilNo = 1537, Adi = "Hasan", Soyadi = "Yalvaç", Resim = "hasan.jpg"},
            new Personel {SicilNo = 1538, Adi = "Hüseyin", Soyadi = "Cesur", Resim = "hüseyin.jpg"}



        };
    }
}
