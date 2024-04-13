using Prometheus;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

/* Configuracao do prometheus começa aqui */

    app.UseMetricServer();
    app.UseHttpMetrics();

/* Configuracao do prometheus termina aqui */

//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
