var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Adiciona os controllers
builder.Services.AddControllers();
// Adicionar os endpoints
builder.Services.AddEndpointsApiExplorer();
// Adicionar o Swagger
builder.Services.AddSwaggerGen();

// Configuração que deixa o nomes das rotas somente com letras minusculas (padrao comum)
builder.Services.AddRouting(option => option.LowercaseUrls = true);

// Pega a seção de configuração do appsettings.json
var teste = builder.Configuration.GetSection("Prop2").Value;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Redireciona a api para usar HTTPS
app.UseHttpsRedirection();

app.UseAuthorization();

// Se os controllers foram adicionados corretamente ao builder la em cima, aqui ele mapeia eles
app.MapControllers();

// A partir daqui abre o browser, swagger e ta tudo pronto pra receber requisições
app.Run();
