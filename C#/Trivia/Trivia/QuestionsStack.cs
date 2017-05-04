using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class QuestionsStack
    {
        private readonly string _category;
        private readonly LinkedList<string> questions;

        public QuestionsStack(string category, IQuestionsRepository source)
        {
            _category = category;
            questions = source.GetQuestions(category);

        }

        public void AskQuestionAndDiscardIt()
        {
            Console.WriteLine("The category is " + _category);
            Console.WriteLine(questions.First());
            questions.RemoveFirst();
        }

     
    }
}