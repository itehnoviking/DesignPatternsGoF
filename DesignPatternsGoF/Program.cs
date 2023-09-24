// See https://aka.ms/new-console-template for more information


#region Abstract Factory

using System.Collections.Immutable;
using AbstractFactory;
using Builder;

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


