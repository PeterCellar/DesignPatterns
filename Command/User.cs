using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // The Invoker class
    public class User
    {
        Calculator calculator = new Calculator();
        List<Command> commands = new List<Command>();
        int current = 0;

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels", levels);

            for (int i = 0; i < levels; i++)
            {
                if (current < commands.Count - 1)
                {
                    Command command = commands[current++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels", levels);

            for(int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    Command command = commands[--current];
                    command.UnExecute();
                }
            }
        }

        public void Compute(char @operator, int operand)
        {
            Command command = new CalculatorCommand(@operator, operand, calculator);
            command.Execute();

            commands.Add(command);

            current++;
        }
    }
}
