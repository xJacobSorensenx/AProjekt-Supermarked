using System;

namespace AProjekt_Supermarked.Models
{
    public class IndkobModel
    {
        //primary key
        public int Id { get; set; }

        public int Antal { get; set; }

        //foreign key over i Varetabellen
        //virtual for at enable lazy-loading
        public virtual int VareID { get; set; }
        public virtual VareModel Vare { get; set; }


        public virtual int HHID { get; set; }
        public virtual HandelsHistorikModel HandelsHistorik { get; set; }

    }
}