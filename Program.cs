using GraphQL_Demo.Schema;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseRouting();

app.UseEndpoints(endpoints => endpoints.MapGraphQL());

app.UseHttpsRedirection();

app.Run();