using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AProjekt_Supermarked.Models
{
    public class KundeModel
    {
        [Key]
        public int KundeID { get; set; }
        public string Navn { get; set; }
        public int Telefon { get; set; }
        public virtual ICollection<HandelsHistorikModel> Handler { get; set; }
    }
}