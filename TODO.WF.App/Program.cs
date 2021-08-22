using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using TODO.WF.App.Views;
using TODO.WF.Dal.Interfaces;
using TODO.WF.Dal.Repositories;
using TODO.WF.Model.Dto;
using TODO.WF.Model.EF;
using TODO.WF.Service.Services;

namespace TODO.WF.App
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// static void ConfigureServices()
        public static IServiceProvider ServiceProvider { get; set; }
        public static IConfiguration Configuration;

        static void ConfigureServices(IServiceCollection services)
        {
            DIConfig.Register(services);
            ServiceProvider = services.BuildServiceProvider();
        }
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            //Run view
            EmployeeView view = new EmployeeView();
            IEmployeeRepository repository = new EmployeeRepository();
            view.Visible = false;
            EmployeeService service = new EmployeeService(view, repository);
            service.LoadView();
            view.ShowDialog();

        }
    }
}
