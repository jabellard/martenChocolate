using Marten;
using MartenChocolate;

var builder = WebApplication.CreateBuilder(args);
var martenConfigurator = builder.Services.AddMarten(_ =>
{
    var options = new StoreOptions();
    var connectionString = builder.Configuration["ConnectionStrings:Marten"];
    options.Connection(connectionString);
    options.DatabaseSchemaName = "martenChocolate";
    return options;
});
martenConfigurator.InitializeWith<DatabaseSeed>();
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddSorting()
    .AddFiltering();

var app = builder.Build();
app.MapGraphQL();
app.Run("http://localhost:3060");
