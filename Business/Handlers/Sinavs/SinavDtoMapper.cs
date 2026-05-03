using Core.Entities.Concrete.Project;
using Entities.Dtos.SinavDto;

namespace Business.Handlers.Sinavs
{
    internal static class SinavDtoMapper
    {
        public static SinavDto ToDto(Sinav sinav)
        {
            if (sinav == null)
                return null;

            return new SinavDto
            {
                Id = sinav.Id,
                KisaAd = sinav.KisaAd,
                Ad = sinav.Ad,
                SiraNo = sinav.SiraNo
            };
        }
    }
}
