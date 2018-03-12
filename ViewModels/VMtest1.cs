using System.Collections.Generic;
using AProjekt_Supermarked.Models;

namespace AProjekt_Supermarked.ViewModels
{
    public class VMtest1
    {
        public IEnumerable<VareModel> Varer { get; set; }
        public IEnumerable<string> Kurven { get; set; }
    }
}