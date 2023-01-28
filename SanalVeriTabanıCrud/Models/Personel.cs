using System.ComponentModel.DataAnnotations;

namespace SanalVeriTabanıCrud.Models
{
    public class Personel
    {
        [Key] //hemen altındaki pro un birincil anahtar(PK) olmasını sağlar buda türü int ise otomotik artışı sağlar
        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Resim { get; set; }
    }
}
