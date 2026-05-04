using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete.Project
{
    public class Sinav:BaseEntity,IEntity
    {
        public string KisaAd { get; set; }
        public string Ad { get; set; }
        public int SiraNo { get; set; }
        public ICollection<Bolum> Bolumler { get; set; }
    }
}
