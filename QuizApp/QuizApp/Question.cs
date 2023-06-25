using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public class Question 
    {

        public string quiz { get; set; }


        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }

        public int TrueAnswer { get; set; }



        public override string ToString()
        {
            return $"Question: {quiz}? \n\n 1. {Answer1}\n 2. {Answer2}\n 3. {Answer3}\n 4. {Answer4}";
        }


    }
}
