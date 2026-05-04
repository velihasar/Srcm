using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete.Project
{
    public class Bolum:BaseEntity,IEntity
    {
        public int SinavId { get; set; }
        public Sinav Sinav { get; set; }
        public string Ad { get; set; }
        public int SiraNo { get; set; }
        public ICollection<Konu> Konular { get; set; }
    }
}
