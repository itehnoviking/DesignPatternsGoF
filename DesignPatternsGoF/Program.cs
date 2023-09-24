// See https://aka.ms/new-console-template for more information


#region Abstract Factory

using AbstractFactory;

Client client = null;

client = new Client(new CodeCompleteFactory());
client.Run();

client = new Client(new ClearCodeFactory());
client.Run();

#endregion


