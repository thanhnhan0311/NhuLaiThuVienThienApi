using MediatR;
using Microsoft.EntityFrameworkCore;
using NhuLaiThuVienThienApi.Data;
using NhuLaiThuVienThienApi.Profiles;
using NhuLaiThuVienThienApi.Repositories;
using System.Reflection;
using System.Text.Json.Serialization;
using TechWizWebApp.Services;

namespace NhuLaiThuVienThienApi
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddDbContext<NhuLaiThuVienThienDbContext>(options => options.UseSqlServer("Data Source=NHANNT;Initial Catalog=NhuLaiThuVienThien;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"));
            services.AddCors(o =>
            {
                o.AddPolicy("CorsPolicy",
                    builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
            services.AddAutoMapper(typeof(OrganizationProfiles));
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IFileService, FileService>();

            services.AddControllers().AddJsonOptions(x =>
               x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            return services;
        }
    }
}
