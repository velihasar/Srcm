using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete.Project
{
    public class Soru:BaseEntity,IEntity
    {
        public int KonuId { get; set; }
        public Konu Konu { get; set; }
        public string Metin { get; set; }
        public string? GorselUrl { get; set; }
        public int SiraNo { get; set; }
        public int ErisimSeviyesi { get; set; }// 1 = Free, 2 = Premium
        public ICollection<SoruSecenek> Secenekler { get; set; }
    }
}
