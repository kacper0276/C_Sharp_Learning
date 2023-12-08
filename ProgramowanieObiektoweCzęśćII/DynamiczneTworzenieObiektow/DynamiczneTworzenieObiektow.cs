using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.DynamiczneTworzenieObiektow
{
    class DynamiczneTworzenieObiektow
    {
        public DynamiczneTworzenieObiektow()
        {
            var provider = new Provider();
            provider.Add<ITest, Test>();
            provider.Add<ISender, Sender>();
            provider.Add<ISendManager, SendManager>();
            provider.Add<OnlyImplementation>();
            var sendManager = provider.ConstructObject<ISendManager>();
            sendManager.SendMessage();
        }
    }


    public class Provider
    {
        private readonly IDictionary<Type, Type> _entries = new Dictionary<Type, Type>();

        public Provider Add<TAbstraction, TImplementation>()
            where TAbstraction : class
            where TImplementation : class, TAbstraction
        {
            _entries[typeof(TAbstraction)] = typeof(TImplementation);
            return this;
        }

        public Provider Add<TImplementation>()
        {
            _entries[typeof(TImplementation)] = typeof(TImplementation);
            return this;
        }

        public T ConstructObject<T>()
        {
            return (T)ConstructObject(typeof(T));
        }

        private object ConstructObject(Type type)
        {
            var concreteType = GetImplementationType(type);
            var paramsConstructor = GetConstructorParams(concreteType);
            return Activator.CreateInstance(concreteType, paramsConstructor) ?? throw new InvalidOperationException($"Cannot construct object from type {type.FullName}");
        }
        private object[] SetParamsConstructor(ParameterInfo[] parameters)
        {
            var paramsConstructor = new object[parameters.Length];
            var index = 0;
            foreach (var parameter in parameters)
            {
                paramsConstructor[index] = ConstructObject(parameter.ParameterType);
                index++;
            }
            return paramsConstructor;
        }

        private object[] GetConstructorParams(Type type)
        {
            var constructor = GetConstructor(type);
            var parameters = constructor.GetParameters();
            return SetParamsConstructor(parameters);
        }

        private static ConstructorInfo GetConstructor(Type type)
        {
            var constructors = type.GetConstructors();
            var constructor = constructors.MaxBy(c => c.GetParameters().Length);

            if (constructor is null)
            {
                throw new InvalidOperationException($"Cannot construct object from type {type.FullName}");
            }

            return constructor;
        }

        private Type GetImplementationType(Type type)
        {
            _entries.TryGetValue(type, out var concreteType);

            if (concreteType is null)
            {
                throw new InvalidOperationException($"Type with {type} was not found in Provider");
            }

            return concreteType;
        }
    }

    class SendManager : ISendManager
    {
        private readonly ISender _sender;
        public SendManager(ISender sender)
        {
            _sender = sender;
        }

        public void SendMessage()
        {
            Console.WriteLine("Sending message");
            _sender.Send();
            Console.WriteLine("Sent message");
        }
    }

    interface ISendManager
    {
        void SendMessage();
    }

    class Sender : ISender
    {
        public Sender(ITest test)
        {
            Console.WriteLine($"Init Sender with params {test.GetType().FullName}");
        }

        public void Send()
        {
            Console.WriteLine("Sending message");
        }
    }

    interface ISender
    {
        void Send();
    }

    class OnlyImplementation
    {
        public OnlyImplementation()
        {
            Console.WriteLine("Init OnlyImplementation");
        }
    }

    class Test : ITest
    {
        public Test(OnlyImplementation onlyImplementation)
        {
            Console.WriteLine($"Init Test with params {onlyImplementation.GetType().FullName}");
        }
    }

    interface ITest
    {

    }
}
