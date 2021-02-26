
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace denetimbulgu.Models
{
    public class Csc
    {
        public int ID { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("CIS 20 Başlık/Açıklama")]
        public string Cıs20_baslik_aciklama { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Numara")]
        public string no { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("CIS Kontrol Maddeleri")]
        public string CIS_kontrol_maddeleri { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("İyi Uygulama Örnekleri")]
        public string iyi_uygulama_ornekleri { get; set; }
        
        [DataType(DataType.MultilineText)]
        [DisplayName("Mevcut Durum Çalışma")]
        public string mevcut_durum_calısma { get; set; }

        [DataType(DataType.MultilineText)]
        [DisplayName("Bundan Önce Ne yapıldı")]
        public string bir_onceki_yapilan { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Gerçekleşen Tarih")]
        public string gerceklesen_tarih { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Planlanan Tarihi")]
        public string bitis_tarihi { get; set; }
        [DataType(DataType.Text)]
        [DisplayName("Sorumlu")]
        public string sorumlu { get; set; }
        [DataType(DataType.Text)]
        [DisplayName("Doküman Dosyası")]
        public string dokumantasyon { get; set; }

        public string olusan_tarih { get; set; }
    }
}