using System.Reflection;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Module = Autofac.Module;

namespace Business.DependencyResolver.Autofac
{
    public class AutofacBusinessModule: Module
    {
        //Burada interface ile class aralarında kurulacak, yani programın tanıması için gerekli olan atamalar yapılacak
        //Services.AddSingleton gibi.

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<ArizaManager>().As<IArizaService>();
            builder.RegisterType<EfArizaDal>().As<IArizaDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<MakineManager>().As<IMakineService>();
            builder.RegisterType<EfMakineDal>().As<IMakineDal>();

            builder.RegisterType<MakineManager>().As<IMakineService>();
            builder.RegisterType<EfMakineDal>().As<IMakineDal>();

            builder.RegisterType<UrunManager>().As<IUrunService>();
            builder.RegisterType<EfUrunDal>().As<IUrunDal>();

            builder.RegisterType<UretimManager>().As<IUretimService>();
            builder.RegisterType<EfUretimDal>().As<IUretimDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<PersonelManager>().As<IPersonelService>();
            builder.RegisterType<EfPersonelDal>().As<IPersonelDal>();

        }
    }
}