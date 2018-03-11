using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AProjekt_Supermarked.Models
{
    public class HandelsHistorikModel
    {
        [Key]
        public int HHID { get; set; }
        public virtual int KundeID  { get; set; }
        public virtual KundeModel Kunde { get; set; }


        public virtual ICollection<IndkobModel> Indkob { get; set; }
        
    }
}