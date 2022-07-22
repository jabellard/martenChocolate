using Marten;

namespace MartenChocolate;

public class Query
{
    [UseFiltering]
    public IQueryable<Book> GetBooks([Service(ServiceKind.Default)] IQuerySession querySession)
    {
        var queryable = querySession.Query<Book>();
        return queryable;
    }
}