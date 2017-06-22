using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class DisplayMessage : IQuestionsUI
    {
        public void Display(string message)
        {
            Console.WriteLine(message);
        }
    }
}
