﻿using MarsRover.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.Implementations
{
    public class Reverse : ICommand
    {
        private readonly int _moveForwards = 1;
        
        public int CommandValue
        {
            get
            {
                return _moveForwards;
            }
        }

    }
}
