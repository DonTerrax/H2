﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    public static class Factory
    {
        public static Person CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(),CreateMessageSender());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IMessageSender CreateMessageSender()
        {
            return new Texter();
        }
    }
}
