﻿using MarsRover.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.Implementations
{
    public class RotateRight : ICommand, IRotate
    {
        private int _turnRightBy = 1;

        public int CommandValue
        {
            get
            {
                return _turnRightBy;
            }
        }
    }
}
