using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class QuestionsStack
    {
        private readonly string _category;
        private readonly LinkedList<string> questions;
        private readonly DisplayMessage _console;

        public QuestionsStack(string category, IQuestionsRepository source, DisplayMessage console)
        {
            _category = category;
            questions = source.GetQuestions(category);
            _console = console;

        }

        public void AskQuestionAndDiscardIt()
        {
            _console.Display("The category is " + _category);
            _console.Display(questions.First());
            questions.RemoveFirst();
        }

     
    }
}