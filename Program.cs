namespace EmployeeProjectEx
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddControllersWithViews();

			var app = builder.Build();
			if(!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();// wwwRoot
			app.UseRouting();
			app.UseAuthorization();
			app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                name: "admin",
                pattern: "{area:exists}/{controller=Home}/{action=Index}");

                endpoints.MapControllerRoute(
				name: "default",
				pattern: "{controller=Employees}/{action=List}/{id?}");

				
			});
			

			app.Run();
		}
	}
}