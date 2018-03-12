using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AProjekt_Supermarked.Models
{
    public class VareKatModel
    {
        [Key]
        public int VareKatID { get; set; }
        public string Kategori { get; set; }

        public virtual ICollection<VareModel> Varer { get; set; }
    }
}