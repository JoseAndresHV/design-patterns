using ConceptualCommand.Commands;
using ConceptualCommand.Invokers;
using ConceptualCommand.Receivers;
using System;

namespace ConceptualCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new();
            invoker.OnStart = new SimpleCommand("Say hi!");

            Receiver receiver = new();
            invoker.OnFinish = new ComplexCommand(receiver, "Save report", "Save Emails");

            invoker.DoSomethingImportant();
        }
    }
}
