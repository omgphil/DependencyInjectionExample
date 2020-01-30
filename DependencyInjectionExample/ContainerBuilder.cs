using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    public class ContainerBuilder
    {
        public IServiceProvider Build()
        {
            ServiceCollection container = new ServiceCollection();

            container.AddSingleton<IOrderManager, OrderManager>();
            container.AddSingleton<IPaymentProcessor, PaymentProcessor>();
            container.AddSingleton<IProductStockRepository, ProductStockRepository>();
            container.AddSingleton<IShippingProcessor, ShippingProcessor>();

            return container.BuildServiceProvider();
        }
    }
}
