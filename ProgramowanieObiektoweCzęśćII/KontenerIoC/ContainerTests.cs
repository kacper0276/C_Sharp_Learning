using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace ProgramowanieObiektoweCzęśćII.KontenerIoC
{
    public class ContainerTests
    {
        [Fact]
        public void given_transient_service_should_always_have_new_object()
        {
            _services.AddTransient<IItemService, ItemService>(); // Za każdym razem nowy obiekt
            var serviceProvider = _services.BuildServiceProvider();

            var itemService1 = serviceProvider.GetRequiredService<IItemService>();
            var itemService2 = serviceProvider.GetRequiredService<IItemService>();
            var itemService3 = serviceProvider.GetRequiredService<IItemService>();

            Assert.NotSame(itemService1, itemService2);
            Assert.NotSame(itemService1, itemService3);
            Assert.NotSame(itemService2, itemService3);
        }

        [Fact]
        public void given_scoped_service_should_have_different_object_for_other_scopes()
        {
            _services.AddScoped<IItemService, ItemService>();
            var serviceProvider = _services.BuildServiceProvider();

            IItemService itemService1;
            IItemService itemService2;
            IItemService itemService3;
            IItemService itemService4;
            using (var scope = serviceProvider.CreateScope()) // W obrębie 1 scope - jedna wartość
            {
                itemService1 = scope.ServiceProvider.GetRequiredService<IItemService>();
                itemService2 = scope.ServiceProvider.GetRequiredService<IItemService>();
            }

            using (var scope = serviceProvider.CreateScope())
            {
                itemService3 = scope.ServiceProvider.GetRequiredService<IItemService>();
                itemService4 = scope.ServiceProvider.GetRequiredService<IItemService>();
            }

            Assert.Same(itemService1, itemService2);
            Assert.Same(itemService3, itemService4);
            Assert.NotSame(itemService1, itemService3);
            Assert.NotSame(itemService1, itemService4);
            Assert.NotSame(itemService2, itemService3);
            Assert.NotSame(itemService2, itemService4);
        }

        [Fact]
        public void given_singleton_service_should_have_always_same_object()
        {
            _services.AddSingleton<IItemService, ItemService>();
            var serviceProvider = _services.BuildServiceProvider();

            IItemService itemService1;
            IItemService itemService2;
            IItemService itemService3;
            IItemService itemService4;

            using (var scope = serviceProvider.CreateScope()) // Singleton - mimo że różne Scope, to będzie ten sam obiekt
            {
                itemService1 = scope.ServiceProvider.GetRequiredService<IItemService>();
                itemService2 = scope.ServiceProvider.GetRequiredService<IItemService>();
            }

            using (var scope = serviceProvider.CreateScope())
            {
                itemService3 = scope.ServiceProvider.GetRequiredService<IItemService>();
                itemService4 = scope.ServiceProvider.GetRequiredService<IItemService>();
            }

            Assert.Same(itemService1, itemService2);
            Assert.Same(itemService3, itemService4);
            Assert.Same(itemService1, itemService3);
            Assert.Same(itemService1, itemService4);
            Assert.Same(itemService2, itemService3);
            Assert.Same(itemService2, itemService4);
        }

        private readonly IServiceCollection _services;

        public ContainerTests()
        {
            _services = new ServiceCollection();
        }
    }
}
