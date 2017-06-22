using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class Questions
    {
        private readonly List<QuestionsStack> _categories = new List<QuestionsStack>();
        private DisplayMessage _console;

        public Questions(IEnumerable<string> categories, IQuestionsRepository _source, DisplayMessage console)
        {
            GenerateQuestions(categories, _source);
            _console = console;
        }

        private void GenerateQuestions(IEnumerable<string> categories, IQuestionsRepository source)
        {
            foreach (var category in categories)
            {
                var questionsStack = new QuestionsStack(category, source, _console);
                
                _categories.Add(questionsStack);
               
            }
        }

        public void AskQuestion(int playerPlace)
        {
            CurrentCategory(playerPlace).AskQuestionAndDiscardIt();
        }
        private QuestionsStack CurrentCategory(int playerPlace)
        {
            return _categories[playerPlace % _categories.Count];
        }
    }
}