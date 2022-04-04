﻿using System;

namespace MarsRovers
{
    internal class Rover
    {
        private Point _position;
        private string _direction;

        internal void SetPosition(Point position)
        {
            _position = position;
        }

        internal Point GetPosition()
        {
            return _position;
        }

        internal void SetDirection(string direction)
        {
            _direction = direction;
        }
        
        internal string GetDirection()
        {
            return _direction;
        }

        internal void Move()
        {
            switch (_direction)
            {
                case "N":
                    _position = new Point(_position.X, _position.Y + 1);
                    break;
                case "S":
                    _position = new Point(_position.X, _position.Y - 1);
                    break;
                case "E":
                    _position = new Point(_position.X + 1, _position.Y);
                    break;
                case "W":
                    _position = new Point(_position.X - 1, _position.Y);
                    break;


            }
        }
    }
}