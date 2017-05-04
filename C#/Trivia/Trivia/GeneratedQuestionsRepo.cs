using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class GeneratedQuestionsRepo : IQuestionsRepository
    {
        public LinkedList<String> GetQuestions(String type)
        {
            LinkedList<string> questionsList = new LinkedList<string>();
            for (int i = 0; i < 50; i++)
            {
                questionsList.AddLast(type + " Question " + i);
            }
            return questionsList;
        }
    }
}