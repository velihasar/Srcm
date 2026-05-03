using Core.Entities;

namespace Entities.Dtos.SinavDto
{
    public class SinavDto : IDto
    {
        public int Id { get; set; }
        public string KisaAd { get; set; }
        public string Ad { get; set; }
        public int SiraNo { get; set; }
    }
}
