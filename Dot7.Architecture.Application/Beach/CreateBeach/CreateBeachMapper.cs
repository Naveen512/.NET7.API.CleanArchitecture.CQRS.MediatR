using AutoMapper;

namespace Dot7.Architecture.Application.Beach.CreateBeach;

public class CreateBeachMapper:Profile
{
    public CreateBeachMapper()
    {
        CreateMap<CreateBeachRequest, Dot7.Architecture.Domain.Entities.Beach>();
    }
}