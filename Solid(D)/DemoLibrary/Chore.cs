using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Chore : IChore
    {
        private ILogger Logger;
        private IMessageSender MessageSender;
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            Logger = logger;
            MessageSender = messageSender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            Logger.Log($"Performed work on { ChoreName }");
        }

        public void CompleteChore()
        {
            IsComplete = true;
            Logger.Log($"Completed { ChoreName }");
            MessageSender.SendMessage(Owner, $"The chore { ChoreName } is complete.");
        }
    }
}
