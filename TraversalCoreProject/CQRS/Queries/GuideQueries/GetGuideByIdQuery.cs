using MediatR;
using TraversalCoreProject.CQRS.Results.GuideResults;

namespace TraversalCoreProject.CQRS.Queries.GuideQueries
{
    public class GetGuideByIdQuery:IRequest<GetGuideByIdQueryResult>
    {
        public int Id { get; set; }

        public GetGuideByIdQuery(int id)
        {
            Id = id;
        }
    }
}
