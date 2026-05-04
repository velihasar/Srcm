using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete.Project
{
    public class Konu:BaseEntity,IEntity
    {
        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }
        public string Ad { get; set; }
        public int SiraNo { get; set; }
        public ICollection<Soru> Sorular { get; set; }
    }
}
