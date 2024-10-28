using Microsoft.EntityFrameworkCore;
using Volunteia.Models;
using OpenAI.Chat;




var builder = WebApplication.CreateBuilder(args);

// Adiciona os servi�os ao cont�iner
builder.Services.AddControllersWithViews(); // Para suporte a MVC

// Adiciona suporte � compila��o em tempo de execu��o para Razor Pages
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

// Configura o contexto do banco de dados com a string de conex�o
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddHttpClient();



var app = builder.Build();

// Configura��o do pipeline de requisi��es HTTP
if (!app.Environment.IsDevelopment())
{
    // Configura o manipulador de exce��es para ambientes de produ��o
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // HSTS padr�o para 30 dias, pode ser ajustado
}

app.UseHttpsRedirection(); // Redireciona HTTP para HTTPS
app.UseStaticFiles(); // Permite servir arquivos est�ticos

app.UseRouting(); // Habilita o roteamento

app.UseAuthorization(); // Habilita a autoriza��o

// Configura��o das rotas padr�o
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Inicializa o banco de dados e aplica migra��es pendentes
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.Migrate(); // Aplica migra��es pendentes
}

app.Run(); // Inicia a aplica��o
