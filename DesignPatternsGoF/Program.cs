// See https://aka.ms/new-console-template for more information

#region Creational Patterns

#region Abstract Factory

using System.Collections.Immutable;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading.Channels;
using AbstractFactory;
using Adapter;
using Bridge.Abstractions;
using Bridge.Implementation;
using Builder;
using Composite;
using Decorator;
using FactoryMethod;
using FactoryMethod.Abstractions;
using Flyweight;
using Prototype;
using Proxy;
using Component = Composite.Component;
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

Console.WriteLine();

#endregion

Console.WriteLine();

#region Structural Patterns

#region Adapter

Target target = new Adapter.Adapter();
target.Request();

#endregion

Console.WriteLine();

#region Bridge

AbstractionBook abstractionBook;

abstractionBook = new TechBook(new ConcreteTextClearCode());
abstractionBook.Operation();

abstractionBook = new TechBook(new ConcreteTextCodeComplete());
abstractionBook.Operation();

#endregion

Console.WriteLine();

#region Composite

Component root = new Composite.Composite("Root");
Component branch1 = new Composite.Composite("Branch 1");
Component branch2 = new Composite.Composite("Branch 2");
Component leaf1 = new Leaf("Leaf 1");
Component leaf2 = new Leaf("Leaf 2");

root.Add(branch1);
root.Add(branch2);

branch1.Add(leaf1);
branch2.Add(leaf2);

root.Operation();

#endregion

Console.WriteLine();

#region Decorator

Decorator.Component book = new ConcreteBook();
Decorator.Decorator bookCover = new BookCoverDecorator();
Decorator.Decorator bookPages = new BookPagesDecorator();

bookCover.Component = book;
bookPages.Component = bookCover;
bookPages.Operation();

#endregion

Console.WriteLine();

#region Facade

Facade.Facade facade = new Facade.Facade();

facade.CreateNewBook();

#endregion

Console.WriteLine();

#region Flyweight

var codeCompleteOriginal = new CodeCompleteOriginal();

CodeCompleteBook codeCompleteBook = new CodeCompleteBook(codeCompleteOriginal);
codeCompleteBook.GetPrice(100);

CodeCompletePdfBook codeCompletePdfBook = new CodeCompletePdfBook(codeCompleteOriginal);
codeCompletePdfBook.GetPrice(50);

#endregion

Console.WriteLine();

#region Proxy

ICompile machineCode = new MachineCode();
ICompile cSharp = new CSharp(machineCode);

cSharp.Compilation();

#endregion

#endregion

Console.WriteLine();