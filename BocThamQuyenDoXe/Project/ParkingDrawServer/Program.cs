var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.WebHost.UseUrls("http://localhost:8386");
var app = builder.Build();

//// Cho phép đọc file tĩnh từ thư mục wwwroot
app.UseDefaultFiles();
app.UseStaticFiles();
app.MapControllers();

app.Run();
