using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    internal class QuestionList
    {
        public string category { get; private set; }
        private LinkedList<string> liste;

        public QuestionList(string category)
        {
            this.category = category;
            this.liste = new LinkedList<string>();
            addQuestion();
        }

        private void addQuestion()
        {
            for (var i = 0; i < 50; i++)
            {
                
                liste.AddLast(category + " Question " + i);
            }
        }

        public void removeQuestion()
        {
            liste.RemoveFirst();
        }

        public string getQuestion()
        {
            string question = liste.First();
            return question;
        }
    }
}