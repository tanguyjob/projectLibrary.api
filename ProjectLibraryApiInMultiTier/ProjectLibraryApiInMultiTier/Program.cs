using ProjectLibraryApiInMultiTier.BLL.Services;
using ProjectLibraryApiInMultiTier.DAL.Interfaces;
using ProjectLibraryApiInMultiTier.DAL.Repositories;
using System.Data.SqlClient;
using Tools.Connections;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200");
                          policy.AllowAnyHeader();
                      });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Config Injection
// - Tools
builder.Services.AddTransient<Connection>((service) =>
{
    return new Connection(
        SqlClientFactory.Instance,
        builder.Configuration.GetConnectionString("Default")
    );
});

// - DAL 
builder.Services.AddTransient<IGenreRepository, GenreRepository>();
builder.Services.AddTransient<IBookRepository, BookRepository>();
builder.Services.AddTransient<IAuthorRepository, AuthorRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IBorrowingBookCustom, BorrowingBookCustomRepository>();
builder.Services.AddTransient<IBookAuthorCustomRepository, BookAuthorCustomRepository>();
builder.Services.AddTransient<IBorrowingRepository, BorrowingRepository>();
builder.Services.AddTransient<IAddessRepository, AddressRepository>();
builder.Services.AddTransient<ILanguageRepositoty, LanguageRepository>();
builder.Services.AddTransient<IBookAuthorRepository, BookAuthorRepository>();

// - BLL 
builder.Services.AddTransient<GenreService>();
builder.Services.AddTransient<BookService>();
builder.Services.AddTransient<AuthorService>();
builder.Services.AddTransient<UserService>();
builder.Services.AddTransient<BorrowingBookCustomService>();
builder.Services.AddTransient<BookAuthorCustomService>();
builder.Services.AddTransient<AddressService>();
builder.Services.AddTransient<BorrowingService>();
builder.Services.AddTransient<LanguageService>();
builder.Services.AddTransient<BookAuthorService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//ajouté 
app.UseStaticFiles();
app.UseRouting();
//----

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();

//private class BookRepository
//{
//}