using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KurumsalWeb.Models.Model
{
    public class New
    {
        [Key]
        public int NewID { get; set; }
        [StringLength(30,ErrorMessage ="30 karakter olmalıdır")]
        [DisplayName("Haber İsmi")]
        public string NewName { get; set; }
        [StringLength(500)]
        [DisplayName("Haber Resmi")]
        public string NewPath { get; set; }
        
        [StringLength(500, ErrorMessage = "500 karakterden az olmalıdır")]
        [DisplayName("Haber  Orta Açıklama")]
        public string NewDescription { get; set; }
        [DisplayName("Haber Sol Üst Açıklama")]
        public string NewDescription1 { get; set; }
        [DisplayName("Haber Sol Alt Açıklama")]
        public string NewDescription2 { get; set; }
        [DisplayName("Haber Sağ Üst Açıklama")]
        public string NewDescription3 { get; set; }

        [DisplayName("Haber Sağ Alt Açıklama")]
        public string NewDescription4 { get; set; }


        public int UserID { get; set; }
        public virtual User User { get; set; }

        public int TvID { get; set; }
        public virtual Tv Tv { get; set; }
    }
}