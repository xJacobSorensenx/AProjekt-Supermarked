using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AProjekt_Supermarked.Models
{
    public class VareModel
    {
        //primary key
        [Key]
        public int VareID { get; set; }

        //navnet på varen
        public string Navn { get; set; }

        

        //prisen på varen
        public int Pris { get; set; }

        //en kort beskrivelse af varen
        public string Beskrivelse { get; set; }

        //en-til-mange; en vare kan optræde i mange forskellige indkøb
        //virtual for at enable lazy-loading
        public virtual ICollection<IndkobModel> Indkob { get; set; }

        public virtual int VareKatID { get; set; }
        public virtual VareKatModel Vare { get; set; }
    
    }
}