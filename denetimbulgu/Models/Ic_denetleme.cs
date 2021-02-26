using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace denetimbulgu.Models
{
    public class Ic_denetleme
    {
        public int id { get; set; }
        [Required]
        [DisplayName("Bulgu Kodu")]
        public string bulgu_kodu { get; set; }
        [DisplayName("Kritiklik Derecesi")]
        public string kritiklik_derecesi { get; set; }
        [DisplayName("Bulgu Tanımı")]
        [DataType(DataType.MultilineText)]
        public string Bulgu_tanimi { get; set; }
        [DisplayName("Son Durum/ Öneri")]
        [DataType(DataType.MultilineText)]
        public string son_durum_oneri { get; set; }
        [DisplayName("Yapılan İşlem")]
        [DataType(DataType.MultilineText)]
        public string Yapilan_is { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("Durum")]
        public string mevcut_durum_calısma { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("Bundan Önce Ne yapıldı")]
        public string bir_onceki_yapilan { get; set; }
        [DisplayName("Sorumlu")]
        public string Sorumlu { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Gerçekleşen Tarih")]
        public string gerceklesen_tarih { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Planlanan Tarihi")]
        public string bitis_tarihi { get; set; }
        [DisplayName("Döküman Dosyası")]
        public string dokumantasyon { get; set; }
        [DisplayName("Eklenme Tarihi")]

        public string eklenme_tarihi { get; set; }
    }
}