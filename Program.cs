using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddMvc(option => option.EnableEndpointRouting = false);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles(); //wwroot => /css/style.css or /img/1.jpeg
app.UseStaticFiles( new  StaticFileOptions{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
    RequestPath ="/modules" // /modules/bootstrap/dist/css/bootstrapmin.css
});
app.UseAuthorization();
app.UseRouting();
app.UseMvcWithDefaultRoute();
app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Run();
