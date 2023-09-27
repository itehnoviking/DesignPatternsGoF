// See https://aka.ms/new-console-template for more information


#region Abstract Factory

using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading.Channels;
using AbstractFactory;
using Builder;
using FactoryMethod;
using FactoryMethod.Abstractions;
using Prototype;

using Product = Builder.Product;

Console.WriteLine("Abstract Factory!");

Client client = null;

client = new Client(new CodeCompleteFactory());
client.Run();

client = new Client(new ClearCodeFactory());
client.Run();

#endregion

Console.WriteLine();

#region Builder

Console.WriteLine("Builder!");

Builder.Abstractions.Builder builder = new ConcreteBuilder();
Director director = new Director(builder);

director.Construct();

Product product = builder.GetResult();
product.Show();

#endregion

Console.WriteLine();

#region Factory Method

Creator creator = null;
FactoryMethod.Abstractions.Product _product = null;

creator = new ConcreteCreator();
_product = creator.FactoryMethod();

#endregion

Console.WriteLine();

#region Prototype

Prototype.Prototype prototype = null;
Prototype.Prototype clone = null;

prototype = new ConcretePrototype(1);
Console.WriteLine(prototype.GetHashCode());

clone = prototype.Clone();
Console.WriteLine(clone.GetHashCode());



var CodeComplete = new BookPrototype();
Console.WriteLine(CodeComplete.GetHashCode());

var ClearCode = CodeComplete.Clone();
Console.WriteLine(ClearCode.GetHashCode());

#endregion

Console.WriteLine();

#region Singleton

var instance1 = Singleton.Singleton.Instance();
var instance2 = Singleton.Singleton.Instance();

Console.WriteLine(ReferenceEquals(instance1, instance2));

#endregion