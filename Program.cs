using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Lesson_17___Project_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Login
            Login();
            #endregion
            int overallScore = 0;

            // TO DO

            //GITHUB
            //500 points random answer
            //CHANGE SCORE









        }
        // =============================================================== END OF MAIN ===================================================================


        // ================================================================= METHODS ======================================================================

        #region MenuMethods

        public static void Login()
        {
            Clear();
            Console.Write("Login name:");
            string user = "x"; int maxCountFail = 0;
            UserName(ref user);
            Clear();
            Menu(user);
        }
        public static void Menu(string user)
        {
            Console.Clear();
            Console.WriteLine("");


            //welcome menu
            Console.Write("              _                          \r\n             | |                         \r\n__      _____| | ___ ___  _ __ ___   ___ \r\n\\ \\ /\\ / / _ \\ |/ __/ _ \\| '_ ` _ \\ / _ \\\r\n \\ V  V /  __/ | (_| (_) | | | | | |  __/\r\n  \\_/\\_/ \\___|_|\\___\\___/|_| |_| |_|\\___|");
            ColorYellow(); Console.WriteLine($"   {user}"); ResetClr();
            Console.WriteLine(
                " ================================================== ");

            ColorRed();
            Console.WriteLine(
                " ================> SELECT ACTION <================= ");
            ResetClr();


            Console.WriteLine(
                "╔════════════╦═══════╦════════════╦════════╦══════╗    \r\n" +
                "║ START GAME ║ RULES ║ STATISTICS ║ LOGOUT ║ QUIT ║" + "\r\n" +
                "╚════════════╩═══════╩════════════╩════════╩══════╝");


            int menuChoiceCount = 0;
            int maxCountFail = 3;

            while (menuChoiceCount < maxCountFail)// 
            {
                string menuChoice = Console.ReadLine().ToLower();


                switch (menuChoice)
                {
                    case "start":
                        StartGame(user);
                        break;
                    case "s":
                        StartGame(user);
                        break;
                    case "rules":
                        RulesScreen();
                        break;
                    case "statistics":
                        StatisticsScreen();
                        break;
                    case "logout":
                        Login(); break;
                    case "quit":
                        QuitSreen(); break;
                    case "q":
                        QuitSreen(); break;
                    default:
                        Console.WriteLine("Invalid entry. Try again: ");
                        menuChoiceCount++;
                        if (menuChoiceCount == maxCountFail) { DeathSreen(); }
                        break;
                }

            }

        }
        //------------meth

        public static void RulesScreen()
        {
            Console.Clear();
            Console.WriteLine("RULES");
        }
        //------------meth

        public static void StatisticsScreen()
        {
            Console.Clear();
            Console.WriteLine("STATISTICS");
            User_Scores();
        }
        //------------meth

        public static void ResultScreen()
        {
            Console.Clear();
            Console.WriteLine("STATISTICS");
        }
        //------------meth

        public static void QuitSreen()
        {
            Console.Clear();
            ColorGreen();
            Console.WriteLine();
            Console.WriteLine(
                "  ▄████  ▒█████   ▒█████  ▓█████▄  ▄▄▄▄ ▓██   ██▓▓█████ " +
                "\r\n ██▒ ▀█▒▒██▒  ██▒▒██▒  ██▒▒██▀ ██▌▓█████▄▒██  ██▒▓█   ▀ " +
                "\r\n▒██░▄▄▄░▒██░  ██▒▒██░  ██▒░██   █▌▒██▒ ▄██▒██ ██░▒███   " +
                "\r\n░▓█  ██▓▒██   ██░▒██   ██░░▓█▄   ▌▒██░█▀  ░ ▐██▓░▒▓█  ▄ " +
                "\r\n░▒▓███▀▒░ ████▓▒░░ ████▓▒░░▒████▓ ░▓█  ▀█▓░ ██▒▓░░▒████▒" +
                "\r\n ░▒   ▒ ░ ▒░▒░▒░ ░ ▒░▒░▒░  ▒▒▓  ▒ ░▒▓███▀▒ ██▒▒▒ ░░ ▒░ ░" +
                "\r\n  ░   ░   ░ ▒ ▒░   ░ ▒ ▒░  ░ ▒  ▒ ▒░▒   ░▓██ ░▒░  ░ ░  ░" +
                "\r\n░ ░   ░ ░ ░ ░ ▒  ░ ░ ░ ▒   ░ ░  ░  ░    ░▒ ▒ ░░     ░   " +
                "\r\n      ░     ░ ░      ░ ░     ░     ░     ░ ░        ░  ░" +
                "\r\n                           ░            ░░ ░            ");
            Environment.Exit(0);


        }

        //------------meth
        public static void DeathSreen()
        {
            Console.Clear();
            ColorRed();
            Console.WriteLine();
            Console.WriteLine(
                     "▓██   ██▓ ▒█████   █    ██      █████▒▄▄▄       ██▓ ██▓    " + "" +
                "\r\n ▒██  ██▒▒██▒  ██▒ ██  ▓██▒   ▓██   ▒▒████▄    ▓██▒▓██▒    " +
                "\r\n  ▒██ ██░▒██░  ██▒▓██  ▒██░   ▒████ ░▒██  ▀█▄  ▒██▒▒██░    " +
                "\r\n  ░ ▐██▓░▒██   ██░▓▓█  ░██░   ░▓█▒  ░░██▄▄▄▄██ ░██░▒██░    " +
                "\r\n  ░ ██▒▓░░ ████▓▒░▒▒█████▓    ░▒█░    ▓█   ▓██▒░██░░██████▒" +
                "\r\n   ██▒▒▒ ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒     ▒ ░    ▒▒   ▓▒█░░▓  ░ ▒░▓  ░" +
                "\r\n ▓██ ░▒░   ░ ▒ ▒░ ░░▒░ ░ ░     ░       ▒   ▒▒ ░ ▒ ░░ ░ ▒  ░" +
                "\r\n ▒ ▒ ░░  ░ ░ ░ ▒   ░░░ ░ ░     ░ ░     ░   ▒    ▒ ░  ░ ░   " +
                "\r\n ░ ░         ░ ░     ░                     ░  ░ ░      ░  ░" +
                "\r\n ░ ░                                                       ");

            Environment.Exit(0);


        }

        #endregion

        //=============================== NEW METHOD AREA ============================

        #region GameQuestions

        public static void StartGame(string user)
        {
            Console.Clear();
            int maxCountFail = 0;//reset fail counter

            Console.WriteLine("            _____          __  __ ______          \r\n  ______   / ____|   /\\   |  \\/  |  ____|  ______ \r\n |______| | |  __   /  \\  | \\  / | |__    |______|\r\n  ______  | | |_ | / /\\ \\ | |\\/| |  __|    ______ \r\n |______| | |__| |/ ____ \\| |  | | |____  |______|\r\n           \\_____/_/    \\_\\_|  |_|______|         \r\n                                                  ");

            string[] categories = { "English ", "Random" };
            string[] scoresEnglish = { "100", "200", "300", "400", "500" };
            string[] scoresRandom = { "100", "200", "300", "400", "500" };

            //display game table


            Console.WriteLine("{0,-15} {1,-15}", categories[0], categories[1]);
            Console.WriteLine("==================================================");

            for (int i = 0; i < scoresEnglish.Length; i++)
            {
                Console.WriteLine("{0,-15} {1,-15}", scoresEnglish[i], scoresRandom[i]);
            }

            Console.WriteLine(
                "==================================================");

            //current player and score
            //string currentPlayer = "Player 1";
            int overallScore = 0;

            Console.Write($"Current Player: "); ColorYellow();
            Console.WriteLine($"{user}"); ResetClr();
            Console.WriteLine($"Current Score: {overallScore}");
            Console.WriteLine(
               " ======> CHOOSE CATEGORY AND POINTS <======= ");
            Console.WriteLine(
                " ====> TYPE 'QUIT' TO RETURN TO MENU <==== ");

            //kategorija
            ChooseCategory(ref overallScore, user, ref scoresEnglish);


            //change already answered English question
            //string userQuestionChoice = Console.ReadLine();
            //int index = Array.IndexOf(scoresEnglish, userQuestionChoice);
            //scoresEnglish[index] = "x";

        }

        #endregion

        //------------meth
        public static int PointsAdd(ref int overallScore, int klausimoTaskai)
        {
            overallScore = overallScore + klausimoTaskai;
            return overallScore;
        }
        //------------meth
        public static int PointsRemove(ref int overallScore, int klausimoTaskai)
        {
            overallScore = overallScore - klausimoTaskai;
            return overallScore;
        }

        //------------meth

        public static void ChooseCategory(ref int overallScore, string user, ref string[] scoresEnglish)
        {
            #region EnglishQuestions

            //2 dictionaries suristi bendru KEY
            Dictionary<int, string> EnglishQuestions = new Dictionary<int, string>()
        {
            {100, "English question 1" },
            {200, "English question 2" },
            {300, "English question 3" },
            {400, "English question 4" },
            {500, "English question 5" },
        };

            Dictionary<int, string> EnglishAnswers = new Dictionary<int, string>()
        {
            {100, "answer" },
            {200, "answer" },
            {300, "answer" },
            {400, "answer" },
            {500, "answer" },
        };
            #endregion

            #region RandomQuestions

            Dictionary<int, string> RandomQuestions = new Dictionary<int, string>()
        {
            {100, "2+2" },
            {200, "Mary’s mother has four children. She named the first Monday. She named the second Tuesday, and she named the third Wednesday. " +
            "\r\nWhat is the name of the fourth child?\r\n" },
            {300, "You are a cyclist in a race. Just before the crossing finish line, you overtake the person in second place. In what place did you finish?" },
            {400, "In a year, there are 12 months. Seven months have 31 days. How many months have 28 days?" },
            {500, "You are driving a bus. At the first stop, two women get on. The second stop, three men get on and one woman gets off. At the third stop, three kids and their mom get on, and a man gets off. The bus is grey, and it is raining outside. \r\nWhat is the name of the bus driver?\r\n" },
        };

            Dictionary<int, string> RandomAnswers = new Dictionary<int, string>()
        {
            {100, "4" },
            {200, "mary" },
            {300, "2" },
            {400, "12" },
            {500, "{user}" },

             };

            Console.WriteLine("Choose the category");
            string chosenCategory = Console.ReadLine().ToLower();

            //didysis pasirinkimas kurios kategorijos
            if (chosenCategory == "english") { Quiz(ref overallScore, user, EnglishQuestions, EnglishAnswers, ref scoresEnglish); }//english 
            else if (chosenCategory == "random") { Quiz(ref overallScore, user, RandomQuestions, RandomAnswers, ref scoresEnglish); };//random

            #endregion


        }
        //------------meth


        //------------meth
        public static void RandomQuiz()
        {
            Console.WriteLine("Input how many points");
        }
        //------------meth

        #region Questions
        public static void Quiz(ref int overallScore, string user, Dictionary<int, string> EnglishQuestions, Dictionary<int, string> EnglishAnswers, ref string[] scoresEnglish)
        {

            Console.WriteLine("How many points");
            int klausimoTaskai = Convert.ToInt32(Console.ReadLine());
            //int index = Array.IndexOf(scoresEnglish, klausimoTaskai);
            //scoresEnglish[index] = "x";


            Console.Clear();
            Console.WriteLine($"You are answering a question for {klausimoTaskai} points");
            Console.WriteLine("");
            Console.WriteLine(EnglishQuestions[klausimoTaskai]);//rodo klausima

            string userAnswer = Console.ReadLine().ToLower(); //User input atsakymas i klausima

            if (userAnswer == EnglishAnswers[klausimoTaskai])
            {
                ColorGreen();
                Console.WriteLine("CORRECT!");
                ResetClr();

                PointsAdd(ref overallScore, klausimoTaskai);
                Console.WriteLine($"+{klausimoTaskai}");
                Console.WriteLine("Press any key to return to game screen");
                string whatever = Console.ReadLine();
                StartGame(user);

            }
            else if (userAnswer != EnglishAnswers[klausimoTaskai])
            {
                ColorRed();
                Console.WriteLine("WRONG!");
                ResetClr();
                Console.WriteLine($"The correct answer was: {EnglishAnswers[klausimoTaskai]}");

                PointsRemove(ref overallScore, klausimoTaskai);
                Console.WriteLine($"-{klausimoTaskai}");
                Console.WriteLine("Press any key to return to game screen");
                string whatever = Console.ReadLine();
                StartGame(user);
            };
        }


        #endregion
        //------------meth

        //=============================== NEW METHOD AREA ============================

        
        public static void UserName(ref string name)
        {
            name = Console.ReadLine();

            string userDriver;
            //RandomAnswers[500] = name;

            if (name == "quit" || name == "exit" || name == "q") { QuitSreen(); }
        }
        
        //------------meth
        public static void User_Scores()
        {
            Dictionary<string, int> userScoreBoard = new Dictionary<string, int>()
            {
            };
            Console.WriteLine("Printing names and ages");
            foreach (var name in userScoreBoard)
            {
                Console.WriteLine($"{name.Key} - {name.Value} ");
            }
        }
        //------------meth

        //------------meth
        public static Dictionary<string, int> RemoveItem(string ItemToDelete, Dictionary<string, int> updatedDictionary)
        {
            updatedDictionary.Remove(ItemToDelete);
            return updatedDictionary;
        }

        //------------meth
        //=============================== NEW METHOD AREA ============================
        #region ColorMethods
        public static void Clear()
        {
            Console.Clear();
        }
        //------------meth
        public static void ColorYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        //------------meth
        public static void ColorRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        //------------meth
        public static void ColorGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        //------------meth
        public static void ResetClr()
        {
            Console.ResetColor();
        }
        //------------meth
        #endregion
        //=============================== END OF METHODS ============================
    }
}