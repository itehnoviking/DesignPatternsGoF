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
using ChainOfResponsibility;
using Command;
using Composite;
using Decorator;
using FactoryMethod;
using FactoryMethod.Abstractions;
using Flyweight;
using Interpreter;
using Iterator;
using Iterator.Interfaces;
using Mediator;
using Memento;
using Observer;
using Prototype;
using Proxy;
using State;
using Component = Composite.Component;
using Context = Interpreter.Context;
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

#region Behavioral Patterns

#region Chain of Responsibility

Handler h1 = new ConcreteHandler1();
Handler h2 = new ConcreteHandler2();

h1.Successor = h2;
h1.HandleRequest(1);
h1.HandleRequest(2);

#endregion

Console.WriteLine();

#region Command

Calculator calculator = new Calculator();
int result = 0;

result = calculator.Add(5);
Console.WriteLine(result);

result = calculator.Sub(3);
Console.WriteLine(result);

Console.WriteLine(new string('-', 3));

result = calculator.Undo(2);
Console.WriteLine(result);

result = calculator.Redo(1);
Console.WriteLine(result);

#endregion

Console.WriteLine();

#region Interpreter

Context context = new Context()
{
    Vocabulary = 'a',
    Source = "aaa"
};

var expression = new NonterminalExpression();
expression.Interpret(context);

Console.WriteLine(context.Result);

#endregion

Console.WriteLine();

#region Iterator

IEnumerable bank = new Bank();
IEnumerator cashier = bank.GetEnumerator();

while (cashier.MoveNext())
{
    Banknote banknote = cashier.Current as Banknote;
    Console.WriteLine(banknote.Nominal);
}

#endregion

Console.WriteLine();

#region Mediator

var mediator = new ConcreteMediator();
var paperFactory = new PaperFactory(mediator);
var printer = new Printer(mediator);
var bookShop = new BookShop(mediator);

mediator.PaperFactory = paperFactory;
mediator.Printer = printer;
mediator.BookShop = bookShop;

paperFactory.MakePaper();

#endregion

Console.WriteLine();

#region Memento

Man David = new Man();
Safe Valberg = new Safe();
David.Money = "100500 $";
Valberg.Wallet = David.PutMoney();
David.Money = "1000 $";
David.GetMoney(Valberg.Wallet);

Console.WriteLine(David.Money);


#endregion

Console.WriteLine();

#region Observer

// Издатель.
Subject subject = new ConcreteSubject();
// Подписчик, с сообщенным лямбда выражением.
Observer.Observer observer = new Observer.Observer(
    (observerState) => Console.WriteLine(observerState + " 1"));
// Подписка на уведомление о событии.
subject.Event += observer;
subject.Event +=
    (observerState) => Console.WriteLine(observerState + " 2");
subject.State = "State ...";
subject.Notify();
Console.WriteLine(new string('-', 11));
// Отписка от уведомлений.
subject.Event -= observer;
subject.Notify();

#endregion

#region State

State.Context contextState = new State.Context(new ConcreteStateA());
contextState.Request();
contextState.Request();

#endregion

#endregion