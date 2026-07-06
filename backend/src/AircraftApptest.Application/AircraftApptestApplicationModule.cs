using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AircraftApptest
{
    [DependsOn(typeof(AircraftApptestCoreModule), typeof(AbpAutoMapperModule))]
    public class AircraftApptestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                cfg.AddMaps(typeof(AircraftApptestApplicationModule).GetAssembly());
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AircraftApptestApplicationModule).GetAssembly());
        }
    }
}
