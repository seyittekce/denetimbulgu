using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace denetimbulgu.Models
{
    public class iso27
    {
        public int id { get; set; }
        [DataType(DataType.Text)]
        [DisplayName("Numara")]
        public string no { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("Öneriler")]
        public string Öneriler { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("Aksiyon")]
        public string Aksiyon { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("Mevcut Durum Çalışma")]
        public string mevcut_durum_calısma { get; set; }
        [DataType(DataType.Text)]
        [DisplayName("Sorumlu")]
        public string sorumlu { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Gerçekleşen Tarih")]
        public string gerceklesen_tarih { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("Bundan Önce Ne yapıldı")]
        public string bir_onceki_yapilan { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Planlanan Tarihi")]
        public string bitis_tarihi { get; set; }
        [DataType(DataType.Text)]
        [DisplayName("Döküman")]
        public string dokuman { get; set; }
        [DataType(DataType.Text)]
        [DisplayName("Oluşan Tarih")]
        public string tarih { get; set; }
    }
}