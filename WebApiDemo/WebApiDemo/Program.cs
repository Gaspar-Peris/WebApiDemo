using Microsoft.AspNetCore.Identity;
using Shared;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Services.Repositories;
using Services.Service;
using Services.UnitOfWork;
using Services.UnitOfWork.Services.Repositories;
using WebApiDemo.Authen;
using WebApiDemo.Authen.Account;
using WebApiDemo.Authen.Exceptions;
using WebApiDemo.Authen.Token;
using WebApiDemo.Data;
using DataAccess.Models;
var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddIdentity<User, IdentityRole<Guid>>(opt =>
{
    opt.Password.RequireDigit = true;
    opt.Password.RequireLowercase = true;
    opt.Password.RequireNonAlphanumeric = true;                                     
    opt.Password.RequireUppercase = true;
    opt.Password.RequiredLength = 8;
    opt.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<AplicationDbContext>();

builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection("JwtOptions"));

builder.Services.AddScoped<IAuthTokenProcessor, AuthTokenProcessor>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAccountService, AccountService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        var exception = context.Features
            .Get<Microsoft.AspNetCore.Diagnostics.IExceptionHandlerFeature>()
            ?.Error;

        context.Response.ContentType = "application/json";

        if (exception is UserAlreadyExistsException ex)
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            await context.Response.WriteAsJsonAsync(new
            {
                error = ex.Message
            });
            return;
        }

        //context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        //await context.Response.WriteAsJsonAsync(new
        //{
          //  error = "An unexpected error occurred"
        //});
    });
});
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.MapPost("/api/account/login", async (Shared.LoginRequest loginRequest, IAccountService accountService) =>
{
    var result = await accountService.LoginAsync(loginRequest);
    return Results.Ok(result); 
});

app.MapPost("/api/account/register", async (Shared.RegisterRequest registerRequest, IAccountService accountService) =>
{
    await accountService.RegisterAsync(registerRequest);
    return Results.Ok();
});

app.MapPost("/api/account/refresh", async (string refreshToken, IAccountService accountService) =>
{
    var result = await accountService.RefreshTokenAsync(refreshToken);
    return Results.Ok(result);
});

app.Run();
