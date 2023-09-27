using System.Net.Http.Headers;
using FactoryMethod.Abstractions;

namespace FactoryMethod
{
    public class ConcreteCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}