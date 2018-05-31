﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Invoker
    {
        private Command _command;

        public void SetCommand(Command command) {
            this._command = command;
        }

        public void ExecuteCommand() {
            _command.Execute();
        }
    }
}
