using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete.Project
{
    public class SoruSecenek:BaseEntity,IEntity
    {
        public int SoruId { get; set; }
        public Soru Soru { get; set; }
        public string Anahtar { get; set; }
        public string? Metin { get; set; }
        public string? GorselUrl { get; set; }
        public bool DogruMu { get; set; }
        
    }
}
