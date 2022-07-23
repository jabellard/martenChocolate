using Marten;

namespace MartenChocolate;

public class Query
{
    [UseFiltering]
    [UseSorting]
    public IExecutable<Book> GetBooks([Service(ServiceKind.Default)] IQuerySession querySession)
    {
        var queryable = querySession.Query<Book>();
        return queryable.AsExecutable();
    }
}