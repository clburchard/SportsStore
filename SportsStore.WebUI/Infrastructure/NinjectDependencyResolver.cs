using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver: IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            //Mock<IProductRepository> mock = new Mock<IProductRepository>();
            //mock.Setup(m => m.Products).Returns( new List<Product>
            //{
            //    new Product { Name = "Football", Price = 25 },
            //    new Product { Name = "Surf Board", Price = 179 },
            //    new Product { Name = "Running Shoes", Price = 95 },
            //    new Product { Name = "Lifting Gloves", Price = 19 },
            //    new Product { Name = "Golf Umbrella", Price = 39 }
            //});

            //kernel.Bind<IProductRepository>().ToConstant(mock.Object);

            kernel.Bind<IProductRepository>().To<EFProductRepository>();
        }
    }
}