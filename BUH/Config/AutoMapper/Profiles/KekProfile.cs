using AutoMapper;

namespace BUH.Config.AutoMapper.Profiles
{
    public class KekProfile : Profile
    {
        public KekProfile()
        {
            CreateMap<DAL.Models.Kek, Domain.Models.Kek>()
                .ReverseMap()
                  .ForMember(x => x.SubTransactionsKekDebet, y => y.Ignore())
                  .ForMember(x => x.SubTransactionsKekKredit, y => y.Ignore());
        }
    }
}
