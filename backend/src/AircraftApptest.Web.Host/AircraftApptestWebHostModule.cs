using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AircraftApptest.EntityFrameworkCore;

namespace AircraftApptest.Web.Host
{
    [DependsOn(typeof(AircraftApptestApplicationModule), typeof(AircraftApptestEntityFrameworkCoreModule), typeof(AbpAspNetCoreModule))]
    public class AircraftApptestWebHostModule : AbpModule
    {
        public override void PreInitialize()
        {
            // Expose all AppServices as dynamic API controllers
            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(AircraftApptestApplicationModule).GetAssembly(),
                    moduleName: "app",
                    useConventionalHttpVerbs: true
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AircraftApptestWebHostModule).GetAssembly());
        }
    }
}
