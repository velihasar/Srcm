using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete.Project
{
    public class SoruSecenek:IEntity
    {
        public int Id { get; set; }
        public int SoruId { get; set; }
        public Soru Soru { get; set; }
        public string Anahtar { get; set; }
        public string? metin { get; set; }
        public string? GorselUrl { get; set; }
        public bool DogruMu { get; set; }
        
    }
}
