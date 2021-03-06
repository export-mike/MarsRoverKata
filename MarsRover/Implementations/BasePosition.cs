﻿using MarsRover.Common;
using MarsRover.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Implementations
{
    public abstract class BasePosition : IPosition
    {
        public BasePosition(int xCoordinate, int yCoordinate, string direction)
        {

        }

        public BasePosition(int xCoordinate, int yCoordinate, CompassDirection? direction)
        {
            _xCoordinate = xCoordinate;
            _yCoordinate = yCoordinate;
            _direction = direction;
        }

        protected int _xCoordinate;
        public int Xcoordinate
        {
            get
            {
                return _xCoordinate;
            }
        }

        protected int _yCoordinate;
        public int Ycoordinate
        {
            get
            {
                return _yCoordinate;
            }
        }

        protected CompassDirection? _direction;
        public CompassDirection? Direction
        {
            get
            {
                return _direction;
            }
        }

        public abstract override string ToString();
    }
}
