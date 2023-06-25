using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            User user = new User();

            user.GenerateUser();
            Console.WriteLine("\n");
            user.Details();
            Console.WriteLine("\n");

            #region QuestionList

            List<Question> Questionslist = new List<Question>()
            {
                new Question()
                {
                    quiz = "visi mokavshireobit daamarcxa farnavazma azo (azoni)",
                    Answer1 = "aderkis",
                    Answer2 = "qujis",
                    Answer3 = "artagis",
                    Answer4 = "saurmagis",
                    TrueAnswer = 2,
                },

                new Question()
                {
                    quiz = "sxva mizezebtan ertad, ram sheuwyo xeli jvarosnebs aegot konstatinopoli 1204 wels",
                    Answer1 = "imperatoris marcxma selchukebtan brdzolashi",
                    Answer2 = "xatmebrdzoleobis gamo dawyebulma shida dapirispirebam",
                    Answer3 = "brdzolam bizantiis saimperatoro taxtisatvis",
                    Answer4 = "dedaqalaqshi dawyebulma didma ajanyebam",
                    TrueAnswer = 3,
                },

                new Question()
                {
                    quiz = "ra ewodeboda polonetis samefosa da litvis didi samtavros gaertianebul saxelmwifos",
                    Answer1 = "rech pospolita",
                    Answer2 = "varshavis sahercogo",
                    Answer3 = "baltiis unia",
                    Answer4 = "livoniis konfederacia",
                    TrueAnswer = 1,
                },

                new Question()
                {
                    quiz = "ra erqva saqartvelos pirvel prezindets",
                    Answer1 = "eduard shevardnadze",
                    Answer2 = "giorgi margvelashvili",
                    Answer3 = "mixeil saakashvili",
                    Answer4 = "zviad gamsaxurdia",
                    TrueAnswer = 4,
                },

                new Question()
                {
                    quiz = "es samefo gansakutrebit izidavda dzvel berdznebs, radgan\naq moipoveboda magali xarisxis oqros dzvirfasi xis masala, cvili seli.\n romelia es samefo",
                    Answer1 = "hereti",
                    Answer2 = "kolxeti",
                    Answer3 = "qartli",
                    Answer4 = "egvipte",
                    TrueAnswer = 2,
                },

                new Question()
                {
                    quiz = "ra erqva pitiuntis episkoposs romelic 325 wels gamartul nikeis saeklesio krebas eswreboda",
                    Answer1 = "stratofile",
                    Answer2 = "sertfile",
                    Answer3 = "porfile",
                    Answer4 = "pandofile",
                    TrueAnswer = 1,
                },

                new Question()
                {
                    quiz = "saqartvelostvis mnishvnelovan romel brdzolashi igebdnen monawileobas jvarosnebi",
                    Answer1 = "didgoris brdzolashi",
                    Answer2 = "basianis brdzolashi",
                    Answer3 = "martyofis brdzolashi",
                    Answer4 = "alanebtan brdzolashi",
                    TrueAnswer = 1,
                },

                new Question()
                {
                    quiz = "romeli wigni daibechda 1629 wels romshi nikifore irbaxis taosnobit",
                    Answer1 = "saxareba",
                    Answer2 = "vefxistyaosani",
                    Answer3 = "qartul-italiuri leqsikoni",
                    Answer4 = "wminda mefeebi",
                    TrueAnswer = 3,
                },

                new Question()
                {
                    quiz = "1851 wlis noembershi romeli italieli kompozitoris operit gaixsna pirveli sezoni tbilisis operisa da baletis teatrshi",
                    Answer1 = "juzepe verdis",
                    Answer2 = "gaetano donicetis",
                    Answer3 = "jakomo puchinis",
                    Answer4 = "fernado dantis",
                    TrueAnswer = 2,
                },

                new Question()
                {
                    quiz = "romeli politikuri mogvawe iyo diplomatiuri misiit dasavlet evropashi me-18 saukuneshi",
                    Answer1 = "grigol xancteli",
                    Answer2 = "rafiel danibegashvili",
                    Answer3 = "vaxtabg VI",
                    Answer4 = "sulxan-saba orbeliani",
                    TrueAnswer = 4,
                },

            };
            #endregion


            user.GenerateQuestions(Questionslist);
            Console.WriteLine("\n\n");

            user.GeneratePoints();

        }
    }
}
