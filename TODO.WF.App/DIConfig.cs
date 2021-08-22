using Microsoft.Extensions.DependencyInjection;
using System;
using System.Text;
using TODO.WF.Service.Services;
using TODO.WF.Dal.Interfaces;
using TODO.WF.Dal.Repositories;
using TODO.WF.App.Views;

namespace TODO.WF.App
{
    public static class DIConfig
    {
        public static void Register(IServiceCollection services)
        { 
            //register dependency for repository
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            //register dependency for controller
        }

    }
}
