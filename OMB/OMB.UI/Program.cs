using OMB.UI.Components;
using OMB.Aplication.UserUseCases;
using OMB.Repositories;
using OMB.Aplication.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


// ACA ESTA LO QUE AGREGAMOS NOSOTROS

//ESTO ES PARA AGREGAR EL SERVICIO DE MIDDLEWARE DE SESIÓN

builder.Services.AddDistributedMemoryCache();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();

builder.Services.AddTransient<addUserUseCase>();
builder.Services.AddTransient<deleteUserUseCase>();
builder.Services.AddTransient<modifyUserUseCase>();
builder.Services.AddTransient<userListUseCase>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

//si no agregas todos los scoped aunque no los uses no funca

builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();

builder.Services.AddScoped<IVehiclePostRepository, VehiclePostRepository>();

builder.Services.AddScoped<IShipRepository, ShipRepository>();

builder.Services.AddScoped<IShipPostRepository, ShipPostRepository>();


// FIN DE LO QUE AGREGAMOS NOSOTROS

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


//ESTO ES PARA HABILITAR EL MIDDLEWARE DE SESIÓN
app.UseSession();



app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
