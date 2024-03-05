using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAssignment.States
{
    public class StateMoveUp : IState<char, bool>
    {
        public IState<char, bool> NextStateFunction(char input)
        {
            switch (input)
            {
                case 'a': return new StateMoveLeft();
                case 'd': return new StateMoveRight();
                default: return new StateMoveUp();

                    
            }
        }

        public bool OutputFunction(char input, SnakeStateMachine snake)
        {
            snake.Move.Y--;
            return true;
        }
    }
}
