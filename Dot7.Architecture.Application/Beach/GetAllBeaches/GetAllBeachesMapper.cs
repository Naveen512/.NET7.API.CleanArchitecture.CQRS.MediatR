using AutoMapper;

namespace Dot7.Architecture.Application.Beach.GetAllBeaches;
public class GetAllBeachesMapper:Profile
{
    public GetAllBeachesMapper()
    {
        CreateMap<Dot7.Architecture.Domain.Entities.Beach,GetAllBeachesResponse>();
    }
}
