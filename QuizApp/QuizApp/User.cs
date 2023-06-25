using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public class User : Question
    {
        public string PersonName { get; set; }
        public int PersonPoint { get; set; } = 0;
        public int PersonBalance { get; set; } = 0;

        public int Barrier { get; set; } = 70;
        public int MaxPoint { get; set; } = 100;
        public int Gift { get; set; } = 500;

        public void GenerateUser()
        {
            Console.Write("Mogesalmebit istoriis gamocdaze,\n gtxov sheiyvanot tqveni saxeli:");

            PersonName = Console.ReadLine();
            

        }


        public void Details()
        {
            Console.WriteLine("detalebi:");
            Console.WriteLine($"{PersonName}, sul aris 10 kitxva, 1 kitxva aris 10 quliani");
            Console.WriteLine($"sheni mizania gadalaxo barieri, romelic ari {Barrier} qula.");
            Console.WriteLine($"maqsimaluri qula aris {MaxPoint}, romlis agebis shemtxvevashi shen miigeb sachuqars: {Gift}$");
            Console.WriteLine($"warmatebebi");
        }



        public void GenerateQuestions(List<Question> questions)
        {


            int QuestCount = 1;
            int count = 0;

            int Person;

            for (int i = 0; i < questions.Count; i++)
            {
                if (count == i)
                {
                    Console.WriteLine($"Shekitxva: {QuestCount}");
                    Console.WriteLine(questions[i]);
                    count++;
                    QuestCount++;
                }

                Console.WriteLine("Sheiyvanet Pasuxi: ");
                Person = int.Parse(Console.ReadLine());

                if (Person == questions[i].TrueAnswer)
                {
                    Console.WriteLine("Tqveni pasuxi sworia");
                    PersonPoint += 10;
                }
                else
                {
                    Console.WriteLine("Tqveni pasuxi araris swori");
                }
                Console.WriteLine("\n\n");
            }

        }




        public void GeneratePoints()
        {
            if (PersonPoint >= Barrier)
            {
                Console.WriteLine($"Gilocav {PersonName}, tqven chaabaret gamocda, Tqven aiget {PersonPoint} qula");
            }
            else
            {
                Console.WriteLine($"Samwuxarod Tqven ver chaabaret gamocda, tqven aiget {PersonPoint} qula");
            }


            if (MaxPoint == PersonPoint)
            {
                PersonBalance += Gift;

                Console.WriteLine($"saxeli: {PersonName}\n Qula: {PersonPoint}\n Prizi: {PersonBalance}$");

            }

            
        }


    }
}
