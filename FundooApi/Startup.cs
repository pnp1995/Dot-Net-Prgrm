using Common.Models;
using FundooManager.Interface;
using FundooManager.Manager;
using FundooRepository.Context;
using FundooRepository.FundooInterface;
using FundooRepository.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Text;

namespace FundooApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContextPool<UserContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddTransient<IAccount, AccountManager>();
            services.AddTransient<IAccountRepo, AccountRepository>();

            services.AddTransient<INotes,NotesManager>();
            services.AddTransient<INotesRepo, NotesRepository>();

            services.AddTransient<ILabel, LabelManager>();
            services.AddTransient<ILabelRepo, LabelRepository>();

            services.AddTransient<ICollaborator, CollaboratorManager>();
            services.AddTransient<ICollaboratorRepo, CollaboratorRepository>();

            services.AddTransient<IAdmin, AdminManager>();
            services.AddTransient<IAdminRepo, AdminRepository>();

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            //swagger
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "FUNDOO NOTE API",
                    Description = "ASP.NET Core Web API"
                });
            });
            // jwt Authentication
            services.Configure<ApplicationSettings>(Configuration.GetSection("ApplicatonSetting"));
            var Key = Encoding.UTF8.GetBytes(Configuration["ApplicatonSetting:JWT_Secret"].ToString());
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x => {
                x.RequireHttpsMetadata = false; 
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true, 
                    IssuerSigningKey = new SymmetricSecurityKey(Key),
                    ValidateIssuer = false, 
                    ValidateAudience = false };

                //AddJwtBearer(x =>
                //{
                //    x.RequireHttpsMetadata = false;
                //    x.SaveToken = true;
                //    x.TokenValidationParameters = new TokenValidationParameters
                //    {
                //        ValidateIssuerSigningKey = true,
                //        IssuerSigningKey = new SymmetricSecurityKey(Key),
                //        ValidateIssuer = false,
                //        ValidateAudience = false,
                //        ClockSkew = TimeSpan.Zero
                //    };
            });
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseCors("MyPolicy");
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "PRITAM");
            });
           
            //app.UseCors(x => x
            //.AllowAnyOrigin()
            //.AllowAnyHeader().AllowAnyMethod()
            //);
        }
    }
}
