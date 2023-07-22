using Autofac;
using Business.Abstarct;
using Business.Concrete;
using DataAccess.Abstarct;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyInjectionResolvers.Autofac
{
    public class AutofacBussinesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>();
            builder.RegisterType<OperationClaimsManager>().As<IOperationClaimsService>();

            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<UserManager>().As<IUserService>();

            builder.RegisterType<EfUserOperationDal>().As<IUserOperationDal>();
            builder.RegisterType<UserOperationManager>().As<IUserOperationService>();

        }
    }
}
