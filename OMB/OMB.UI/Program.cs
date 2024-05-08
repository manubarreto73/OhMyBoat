using OMB.UI;
using OMB.UI.Components;
using OMB.Aplication.UserUseCases;
using OMB.Aplication.EmployeeUseCases;
using OMB.Aplication.VehicleUseCases;
using OMB.Aplication.VehiclePostUseCases;
using OMB.Aplication.VehicleImageUseCases;
using OMB.Aplication.ShipUseCases;
using OMB.Aplication.ShipPostUseCases;
using OMB.Aplication.ShipImageUseCases;
using OMB.Repositories;
using OMB.Aplication.Interfaces;
//Cosas para la sesión
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

using(OMBContext context = new OMBContext()){
    context.Database.EnsureCreated();
}
Testing.Initialize();

// ACA ESTA LO QUE AGREGAMOS NOSOTROS

builder.Services.AddTransient<addUserUseCase>();
builder.Services.AddTransient<deleteUserUseCase>();
builder.Services.AddTransient<modifyUserUseCase>();
builder.Services.AddTransient<userListUseCase>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddTransient<addEmployeeUseCase>();
builder.Services.AddTransient<deleteEmployeeUseCase>();
builder.Services.AddTransient<modifyEmployeeUseCase>();
builder.Services.AddTransient<employeeListUseCase>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

builder.Services.AddTransient<addVehicleUseCase>();
builder.Services.AddTransient<deleteVehicleUseCase>();
builder.Services.AddTransient<modifyVehicleUseCase>();
builder.Services.AddTransient<vehicleListUseCase>();
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();

builder.Services.AddTransient<addVehiclePostUseCase>();
builder.Services.AddTransient<deleteVehiclePostUseCase>();
builder.Services.AddTransient<modifyVehiclePostUseCase>();
builder.Services.AddTransient<vehiclePostListUseCase>();
builder.Services.AddScoped<IVehiclePostRepository, VehiclePostRepository>();

builder.Services.AddTransient<addVehicleImageUseCase>();
builder.Services.AddTransient<listVehicleImagesUseCase>();
builder.Services.AddScoped<IVehicleImageRepository, VehicleImageRepository>();

builder.Services.AddTransient<addShipUseCase>();
builder.Services.AddTransient<deleteShipUseCase>();
builder.Services.AddTransient<modifyShipUseCase>();
builder.Services.AddTransient<shipListUseCase>();
builder.Services.AddScoped<IShipRepository, ShipRepository>();

builder.Services.AddTransient<addShipPostUseCase>();
builder.Services.AddTransient<deleteShipPostUseCase>();
builder.Services.AddTransient<modifyShipPostUseCase>();
builder.Services.AddTransient<shipPostListUseCase>();
builder.Services.AddScoped<IShipPostRepository, ShipPostRepository>();

builder.Services.AddTransient<addShipImageUseCase>();
builder.Services.AddTransient<listShipImagesUseCase>();
builder.Services.AddScoped<IShipImageRepository, ShipImageRepository>();

// FIN DE LO QUE AGREGAMOS NOSOTROS

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
