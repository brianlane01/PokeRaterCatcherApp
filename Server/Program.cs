using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using PokemonCatcherGame.Server.Data;
using PokemonCatcherGame.Server.Entities;
using PokemonCatcherGame.Server.Services.PokemonMoveServices;
using PokemonCatcherGame.Server.Services.PokemonServices;
using PokemonCatcherGame.Server.Services.PokemonTypeServices;
using PokemonCatcherGame.Server.Services.StatusConditionServices;
using Microsoft.AspNetCore.Identity;
using Server.Services.PokemonAbilityServices;
using Server.Services.StatusConditionItemServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("PokemonDB") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddScoped<IPokemonService, PokemonService>();
builder.Services.AddScoped<IStatusConditionService, StatusConditionService>();
builder.Services.AddScoped<IPokemonTypeService, PokemonTypeService>();
builder.Services.AddScoped<IPokemonMoveService, PokemonMoveService>();
builder.Services.AddScoped<IPokemonAbilityService, PokemonAbilityService>();
builder.Services.AddScoped<IStatusConditionItemService, StatusConditionItemService>();

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddIdentityServer()
    .AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

builder.Services.AddAuthentication()
    .AddIdentityServerJwt();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseIdentityServer();
app.UseAuthorization();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
