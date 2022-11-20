﻿using Data;
using Microsoft.EntityFrameworkCore;

namespace PaymentRecorder;

public class Startup
{

    public IConfiguration Configuration { get; set; }
    
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        string connectionString = Configuration.GetConnectionString("DefaultConnection");


        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddDbContext<EfDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        },ServiceLifetime.Transient);

    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {

        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}