using System;

namespace AProjekt_Supermarked.Models
{
    public class IndkobModel
    {
        //primary key
        public int Id { get; set; }

        //shopping key - dato duer ikke hvis der handles flere gange på samme dag
        public int Fakturanummer { get; set; }

        //dato for indkøbet
        public DateTime Dato { get; set; }
    
        //foreign key over i Varetabellen
        //virtual for at enable lazy-loading
        public virtual int VareID { get; set; }
        public virtual VareModel Vare { get; set; }

    }
}