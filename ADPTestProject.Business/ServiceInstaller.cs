using ADPTestProject.Business.IService;
using ADPTestProject.Business.Service;
using Autofac;

namespace ADPTestProject.Business
{
    public class ServiceInstaller : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(ContactService)).As<IContactService>();
        }
    }
}
