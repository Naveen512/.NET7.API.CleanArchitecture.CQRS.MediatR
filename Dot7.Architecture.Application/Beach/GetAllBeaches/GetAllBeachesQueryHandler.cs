using AutoMapper;
using AutoMapper.QueryableExtensions;
using Dot7.Architecture.Application.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Dot7.Architecture.Application.Beach.GetAllBeaches;

public class GetAllBeachesQueryHandler : IRequestHandler<GetAllBeachesRequest, List<GetAllBeachesResponse>>
{
    private readonly IMyWorldDbContext _myWorldDbContext;
    private readonly IMapper _mapper;
    public GetAllBeachesQueryHandler(IMyWorldDbContext myWorldDbContext,
    IMapper mapper)
    {
        _myWorldDbContext = myWorldDbContext;
        _mapper = mapper;
    }
    public Task<List<GetAllBeachesResponse>> Handle(GetAllBeachesRequest request, CancellationToken cancellationToken)
    {
        return _myWorldDbContext.Beach.ProjectTo<GetAllBeachesResponse>(_mapper.ConfigurationProvider)
        .ToListAsync();
    }
}