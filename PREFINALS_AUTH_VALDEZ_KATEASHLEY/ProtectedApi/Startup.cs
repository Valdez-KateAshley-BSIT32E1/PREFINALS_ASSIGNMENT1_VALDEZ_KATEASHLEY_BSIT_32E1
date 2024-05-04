using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

public class Startup
{
    // Other configuration methods

    public void ConfigureServices(IServiceCollection services)
    {
        // Add authentication services
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = "yourIssuer", // Specify the issuer of the token
                ValidAudience = "yourAudience", // Specify the audience of the token
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("yourSecretKey")) // Specify the key used to sign the token
            };
        });

        services.AddControllers();
    }

    // Other methods

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Other middleware configurations

        // Enable authentication middleware
        app.UseAuthentication();

        // Other middleware configurations

        app.UseAuthorization();

        // Other middleware configurations
    }
}
