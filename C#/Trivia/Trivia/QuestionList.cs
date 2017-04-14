using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    internal class QuestionList
    {
        public string Category { get; private set; }
        private readonly LinkedList<string> _liste;

        public QuestionList(string category)
        {
            this.Category = category;
            this._liste = new LinkedList<string>();
            AddQuestion();
        }

        private void AddQuestion()
        {
            for (var i = 0; i < 50; i++)
            {
                
                _liste.AddLast(Category + " Question " + i);
            }
        }

        public void RemoveQuestion()
        {
            _liste.RemoveFirst();
        }

        public string GetQuestion()
        {
            var question = _liste.First();
            return question;
        }
    }
}