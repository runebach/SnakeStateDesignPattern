﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAssignment.States
{
    public class StateMoveLeft : IState<char, bool>
    {
        public IState<char, bool> NextStateFunction(char input)
        {
            switch (input)
            {
                case 'w': return new StateMoveUp();
                case 's': return new StateMoveDown();
                default: return new StateMoveLeft();


            }
        }

        public bool OutputFunction(char input, SnakeStateMachine snake)
        {
            snake.Move.X--;
            return true;
        }
    }
}
