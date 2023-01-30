using ServiceContracts;
using Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IFinnhubService, FinnhubService>();
builder.Services.AddSingleton<IStocksService, StocksService>();


var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}



app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
