using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    internal class Questions
    {
        internal readonly LinkedList<string> _popQuestions = new LinkedList<string>();
        internal readonly LinkedList<string> _scienceQuestions = new LinkedList<string>();
        internal readonly LinkedList<string> _sportsQuestions = new LinkedList<string>();
        internal readonly LinkedList<string> _rockQuestions = new LinkedList<string>();

        private readonly Dictionary<int, string> _categories = new Dictionary<int, string>() { { 0, "Pop" }, { 1, "Science" }, { 2, "Sports" }, { 3, "Rock" } };
        
        public void AskQuestion(int currentPlace)
        {
            if (CurrentCategory(currentPlace) == "Pop")
            {
                Console.WriteLine(_popQuestions.First());
                _popQuestions.RemoveFirst();
            }
            if (CurrentCategory(currentPlace) == "Science")
            {
                Console.WriteLine(_scienceQuestions.First());
                _scienceQuestions.RemoveFirst();
            }
            if (CurrentCategory(currentPlace) == "Sports")
            {
                Console.WriteLine(_sportsQuestions.First());
                _sportsQuestions.RemoveFirst();
            }
            if (CurrentCategory(currentPlace) == "Rock")
            {
                Console.WriteLine(_rockQuestions.First());
                _rockQuestions.RemoveFirst();
            }
        }

        internal string CurrentCategory(int currentPlace)
        {
            return _categories[currentPlace % 4];
        }

        
    }
}