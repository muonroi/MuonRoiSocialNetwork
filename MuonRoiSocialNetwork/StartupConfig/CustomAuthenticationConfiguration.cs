﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;
using MuonRoiSocialNetwork.Common.Settings.Appsettings;

namespace MuonRoiSocialNetwork.StartupConfig
{
    internal static class CustomAuthenticationConfiguration
    {
        public static IServiceCollection CustomAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            SymmetricSecurityKey symmetricKey = new(Convert.FromBase64String(configuration[ConstAppSettings.Instance.APPLICATIONSERECT] ?? "Application:SERECT"));
            string? myIssuer = configuration[ConstAppSettings.Instance.ENV_SERECT];
            string? myAudience = configuration[ConstAppSettings.Instance.APPLICATIONAPPDOMAIN];
            TokenValidationParameters validationParameters = new()
            {
                ValidateIssuerSigningKey = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                IssuerSigningKey = symmetricKey,
                ValidIssuer = myIssuer,
                ValidAudience = myAudience,
                ClockSkew = TimeSpan.Zero
            };
            services.AddAuthentication(delegate (AuthenticationOptions x)
            {
                x.DefaultAuthenticateScheme = "Bearer";
                x.DefaultChallengeScheme = "Bearer";
            }).AddJwtBearer(delegate (JwtBearerOptions x)
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = validationParameters;
            });
            return services;
        }
    }
}
