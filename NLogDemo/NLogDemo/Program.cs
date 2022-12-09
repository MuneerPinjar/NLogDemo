// See https://aka.ms/new-console-template for more information

using NLog;
var logger =LogManager.GetCurrentClassLogger();

Console.WriteLine("Hello, World!");
logger.Error("This is Error Message");

Console.ReadLine();
