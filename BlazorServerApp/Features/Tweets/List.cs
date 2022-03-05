using MediatR;
namespace BlazorServerApp.Features.Tweets;

public class List
{
    public class Query : IRequest<Model>
    {
        
    }
    
    public class Model
    { 
        public List<string> Tweets { get; set; }
    }
    
    public class QueryHandler : IRequestHandler<Query, Model>
    {
        public async Task<Model> Handle(Query request, CancellationToken cancellationToken)
        {
            return new Model
            {
                Tweets = new List<string>
                {
                    "One from server",
                    "Two from server",
                    "Three from server",
                    "Four"
                }
            };
        }   
        
    }
}