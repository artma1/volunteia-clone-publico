using Microsoft.EntityFrameworkCore;
using Volunteia.Models;
using OpenAI.Chat;




var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços ao contêiner
builder.Services.AddControllersWithViews(); // Para suporte a MVC

// Adiciona suporte à compilação em tempo de execução para Razor Pages
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

// Configura o contexto do banco de dados com a string de conexão
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddHttpClient();



var app = builder.Build();

// Configuração do pipeline de requisições HTTP
if (!app.Environment.IsDevelopment())
{
    // Configura o manipulador de exceções para ambientes de produção
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // HSTS padrão para 30 dias, pode ser ajustado
}

app.UseHttpsRedirection(); // Redireciona HTTP para HTTPS
app.UseStaticFiles(); // Permite servir arquivos estáticos

app.UseRouting(); // Habilita o roteamento

app.UseAuthorization(); // Habilita a autorização

// Configuração das rotas padrão
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Inicializa o banco de dados e aplica migrações pendentes
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.Migrate(); // Aplica migrações pendentes
}

app.Run(); // Inicia a aplicação
