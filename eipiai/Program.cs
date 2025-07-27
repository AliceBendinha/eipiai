using eipiai.InfraExtrutura;
using eipiai.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the containe
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//injeção de dependencia
builder.Services.AddTransient<IlivrosRepository, LivrosRepository>();  

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
