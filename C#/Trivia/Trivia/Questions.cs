using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    internal class Questions
    {
        private List <QuestionList> _questionStack = new List<QuestionList>();

        private readonly Dictionary<int, string> _categories = new Dictionary<int, string>() { { 0, "Pop" }, { 1, "Science" }, { 2, "Sports" }, { 3, "Rock" } };

        public Questions()
        {
            _questionStack.Add(new QuestionList("Pop"));
            _questionStack.Add(new QuestionList("Science"));
            _questionStack.Add(new QuestionList("Sports"));
            _questionStack.Add(new QuestionList("Rock"));
        }
        public string AskQuestion(int currentPlace)
        {
            QuestionList questionList = CurrentCategory(currentPlace);
            Console.WriteLine("The category is " + questionList.category);
            string question = questionList.getQuestion();
            questionList.removeQuestion();
            Console.WriteLine(question);
            return question;
        }

        internal QuestionList CurrentCategory(int currentPlace)
        {
            return _questionStack[currentPlace % 4];
        }

        
    }
}