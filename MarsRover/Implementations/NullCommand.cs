﻿using MarsRover.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.Implementations
{
    public class NullCommand : ICommand
    {
        public int CommandValue
        {
            get
            {
                return 0;
            }
        }
    }
}
