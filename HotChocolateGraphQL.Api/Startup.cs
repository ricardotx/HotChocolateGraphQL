using HotChocolateGraphQL.Api.GraphQL.Queries;
using HotChocolateGraphQL.Data.Context;
using HotChocolateGraphQL.Data.Repository;
using HotChocolateGraphQL.Data.Repository.Contracts;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace HotChocolateGraphQL.Api
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HotChocolateGraphQL.Api v1"));
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			// GraphQL config
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapGraphQL();
			});

			//app.UseEndpoints(endpoints =>
			//{
			//	endpoints.MapControllers();
			//});
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			// Database connection config
			string connectionStr = Configuration.GetConnectionString("mysqlConString");
			services.AddDbContext<ApplicationContext>(opt => opt.UseMySql(connectionStr, ServerVersion.AutoDetect(connectionStr)));

			// Repositories
			services.AddScoped<IOwnerRepository, OwnerRepository>();
			services.AddScoped<IAccountRepository, AccountRepository>();

			// GraphQL Resolvers
			//services.AddScoped<IOwnerResolver, OwnerResolver>();
			//services.AddScoped<IAccountResolver, AccountResolver>();

			// GraphQL config
			services
				.AddGraphQLServer()
				.AddQueryType<RootQuery>();

			services.AddControllers();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "HotChocolateGraphQL.Api", Version = "v1" });
			});
		}
	}
}
