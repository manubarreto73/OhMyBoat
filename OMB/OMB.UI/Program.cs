using OMB.UI.Components;
using OMB.UI;
using OMB.Aplication.UserUseCases;
using OMB.Aplication.EmployeeUseCases;
using OMB.Aplication.VehicleUseCases;
using OMB.Aplication.PostUseCases;
using OMB.Aplication.VehicleImageUseCases;
using OMB.Aplication.ShipUseCases;
using OMB.Aplication.ShipImageUseCases;
using OMB.Aplication.TransportUseCases;
using OMB.Aplication.OfferUseCases;
using OMB.Aplication.VehicleHistoryUseCases;
using OMB.Aplication.ShipHistoryUseCases;
using OMB.Aplication.ResolvedExchangeUseCases;
using OMB.Aplication.UnresolvedExchangeUseCases;
using OMB.Aplication.SedeUseCases;
using OMB.Repositories;
using OMB.Aplication.Interfaces;
using QuestPDF;

// please kindly ensure what license is appropriate for your project
//QuestPDF.Settings.License = LicenseType.Community;

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

builder.Services.AddTransient<addVehicleImageUseCase>();
builder.Services.AddTransient<listVehicleImagesUseCase>();
builder.Services.AddScoped<IVehicleImageRepository, VehicleImageRepository>();

builder.Services.AddTransient<addShipUseCase>();
builder.Services.AddTransient<deleteShipUseCase>();
builder.Services.AddTransient<modifyShipUseCase>();
builder.Services.AddTransient<shipListUseCase>();
builder.Services.AddScoped<IShipRepository, ShipRepository>();

builder.Services.AddTransient<addShipImageUseCase>();
builder.Services.AddTransient<listShipImagesUseCase>();
builder.Services.AddScoped<IShipImageRepository, ShipImageRepository>();

builder.Services.AddTransient<addPostUseCase>();
builder.Services.AddTransient<deletePostUseCase>();
builder.Services.AddTransient<modifyPostUseCase>();
builder.Services.AddTransient<listPostUseCase>();
builder.Services.AddScoped<IPostRepository, PostRepository>();

builder.Services.AddTransient<addTransportUseCase>();
builder.Services.AddTransient<deleteTransportUseCase>();
builder.Services.AddTransient<modifyTransportUseCase>();
builder.Services.AddTransient<listTransportUseCase>();
builder.Services.AddScoped<ITransportRepository, TransportRepository>();

builder.Services.AddTransient<addOfferUseCase>();
builder.Services.AddTransient<deleteOfferUseCase>();
builder.Services.AddTransient<modifyOfferUseCase>();
builder.Services.AddTransient<offerListUseCase>();
builder.Services.AddScoped<IOfferRepository, OfferRepository>();

builder.Services.AddTransient<addVehicleHistoryUseCase>();
builder.Services.AddTransient<deleteVehicleHistoryUseCase>();
builder.Services.AddTransient<modifyVehicleHistoryUseCase>();
builder.Services.AddTransient<vehicleHistoryListUseCase>();
builder.Services.AddScoped<IVehicleHistoryRepository, VehicleHistoryRepository>();

builder.Services.AddTransient<addShipHistoryUseCase>();
builder.Services.AddTransient<deleteShipHistoryUseCase>();
builder.Services.AddTransient<modifyShipHistoryUseCase>();
builder.Services.AddTransient<shipHistoryListUseCase>();
builder.Services.AddScoped<IShipHistoryRepository, ShipHistoryRepository>();

builder.Services.AddTransient<addResolvedExchangeUseCase>();
builder.Services.AddTransient<deleteResolvedExchangeUseCase>();
//builder.Services.AddTransient<modifyResolvedExchangeUseCase>();
builder.Services.AddTransient<resolvedExchangeListUseCase>();
builder.Services.AddScoped<IResolvedExchangeRepository, ResolvedExchangeRepository>();

builder.Services.AddTransient<addUnresolvedExchangeUseCase>();
builder.Services.AddTransient<deleteUnresolvedExchangeUseCase>();
builder.Services.AddTransient<modifyUnresolvedExchangeUseCase>();
builder.Services.AddTransient<unresolvedExchangeListUseCase>();
builder.Services.AddScoped<IUnresolvedExchangeRepository, UnresolvedExchangeRepository>();

builder.Services.AddTransient<addSedeUseCase>();
builder.Services.AddTransient<deleteSedeUseCase>();
builder.Services.AddTransient<modifySedeUseCase>();
builder.Services.AddTransient<listSedesUseCase>();
builder.Services.AddScoped<ISedeRepository, SedeRepository>();


builder.Services.AddControllers();  // para el controller del pdf
builder.Services.AddHttpClient();
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
app.UseRouting();
app.UseAntiforgery();

app.MapControllers();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
