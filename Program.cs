
//  T6 

/* محمد یاسین ولی پور */

/* mohamad yasin valipor */

string input;
ConsoleKeyInfo click;
Console.WriteLine("\nThis Program Ask some Question by yes or no about Yourself\nThere are 5 groups of Questions in this Program\nif you want start press (1 to 5) to start a group questions  >>");

do
{
    Console.WriteLine("\n--------------\n");
    Console.WriteLine("1) First group : About Your Job\n2) Second group : Trees and Flowers\n3) Third group : Smoking\n4) 4th group : Driving\n5) 5th group : About The Program\n");
    Console.Write("I Chose Group : ");
    input = Console.ReadLine();

    switch (input)
    {
        /////////////////////Start group 1

        case "1":

            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n......THIS IS FIRST(1) GROUPE OF QUESTION...... \n");
            Console.ResetColor();

            FirstGroupQS();
            break;

        /////////////////////Start group 2

        case "2":

            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n......THIS IS SECOND(2) GROUPE OF QUESTION...... \n");
            Console.ResetColor();

            SecondGroupQS();
            break;

        /////////////////////Start group 3

        case "3":

            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n......THIS IS THIRD(3) GROUPE OF QUESTION...... \n");
            Console.ResetColor();

            ThirdGroupQS();
            break;

        /////////////////////Start group 4

        case "4":

            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n......THIS IS FOURTH(4th) GROUPE OF QUESTION...... \n");
            Console.ResetColor();

            FourthGroupQS();
            break;

        /////////////////////Start group 5

        case "5":

            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n......THIS IS FIFTH(5th) GROUPE OF QUESTION...... \n");
            Console.ResetColor();

            FifthGroupQS();
            break;

    }

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n**** If you want to continue , press the Space ****\n**** If you want to Finish the  program , press the Escape (Esc) ****");
    Console.ResetColor();
    click = Console.ReadKey(true);

} while (click.Key == ConsoleKey.Spacebar || click.Key != ConsoleKey.Escape);

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\n< Thanks You For Using This Program >");
Console.ResetColor();


/////*    Methods    */////

////1////
void FirstGroupQS()
{
    Console.Write("your age more than 20 ? (y/n)  ");//1
    if (Console.ReadLine().ToLower() == "y")//1yes
    {
        Console.Write("good\ndo you have a job ? (y/n)  ");//2
        if (Console.ReadLine().ToLower() == "y")//2yes
        {
            Console.Write("Have you been working for more than 3 years ? (y/n)  ");//3
            if (Console.ReadLine().ToLower() == "y")//3yes
            {
                Console.Write("you can work everywhere\n do you like yor jub ? (y/n)  ");//4
                if (Console.ReadLine().ToLower() == "y")//4yes

                    Console.Write("you will be a successful person");

                else//4no

                    Console.Write("don't worry just do it ");

            }
            else//3no
            {
                Console.Write("when you have job so can earn money,\nif you don't get up . you will in future make a big job for yourself");
            }
        }
        else//2no
        {
            Console.Write("so,Do you khnow a special job? (y/n)  ");//5
            if (Console.ReadLine().ToLower() == "y")//5yes
            {
                Console.Write("it's very good i hope you, find your favourit job that you love it");
            }
            else//5no
            {
                Console.Write("try a learn special work for yourself\ntry hard to make a good life ;) ");
            }

        }

    }
    else//1no
    {
        Console.Write("if you have a job at this age.. ,\nso you are a \"HardWorking\" person\nGood Lock");
    }
}



////2////
void SecondGroupQS()
{
    Console.Write("are you have a garden ? (y/n)  ");//1
    if (Console.ReadLine().ToLower() == "y")//1yes
    {
        Console.Write("So i talk about your garden\nDo you agree ? (y/n)  ");//2
        if (Console.ReadLine().ToLower() == "y")//2yes
        {
            Console.Write("have very flowers in your garden  ? (y/n)  ");//3
            if (Console.ReadLine().ToLower() == "y")//3yes
            {
                Console.Write("What a beautiful garden you have\nDo you also produce honey ? (y/n)  ");//4
                if (Console.ReadLine().ToLower() == "y")//4yes

                    Console.Write("You are a successful person and\nyou always have a good feeling with your beautiful garden");

                else//4no

                    Console.Write("Oh, I thought like That\nbut it's an interesting idea to produce honey\nGood luck");

            }
            else//3no
            {
                Console.Write("flowers are very good\ni think You planted more trees instead of flowers , Do You ? (y/n)  ");//3
                if (Console.ReadLine().ToLower() == "y")//3yes
                {
                    Console.Write("You are a smart person");
                }
                else
                {
                    Console.Write("not important\nBecause the whole garden gives a good feeling by one flower/tree or more flowers/trees ");
                }

            }
        }
        else//2no
        {
            Console.Write("ooh\nbut i like talk about it\nit's ok\nHave you ever searched about the benefits of a garden ? (y/n)  ");//5
            if (Console.ReadLine().ToLower() == "y")//5yes
            {
                Console.Write("Good\nSo you know about garden\nHave a Good days");
            }
            else//5no
            {
                Console.Write("Because you didn't want to continue\nSo Go search for yourself and see what the benefits of the garden are :/ ");
            }

        }

    }
    else//1no
    {
        Console.Write("Ok\nbut flowers and green plant change your fell and better it\ni suggestion sure you make a small garden\nTHAT IS VERY GOOD ");
    }
}


////3////
void ThirdGroupQS()
{
    Console.Write("do you smoke ? (y/n)  ");//1
    if (Console.ReadLine().ToLower() == "y")//1yes
    {
        Console.Write("It is very bad because it is very harmful to your health\nHave you ever tried to quit smoking ? (y/n)");//2
        if (Console.ReadLine().ToLower() == "y")//2yes
        {
            Console.Write("did you succeed  ? (y/n)");//3
            if (Console.ReadLine().ToLower() == "y")//3yes
            {
                Console.Write("So you don't smoke now!\nDo not continue and build a new life");//4
            }
            else//3no
            {
                Console.Write("Try to leave it again ;)");//3

            }
        }
        else//2no
        {
            Console.Write("Please go to the nearest drug addiction camp so that you don't destroy your life in the future ");//5
        }

    }
    else//1no
    {
        Console.Write("You do the best\r\nAnd you keep your health\nDo you exercise to improve your health ? (y/n)  ");//2
        if (Console.ReadLine().ToLower() == "y")//2yes
        {
            Console.Write("Great\nHaving an exercise routine is great\n Do you exercise in the morning ? (y/n)  ");//3
            if (Console.ReadLine().ToLower() == "y")//3yes
            {
                Console.Write("in the morning is very good to exercise Especially walking\nDo you do all the sports ? (y/n)  ");//4
                if (Console.ReadLine().ToLower() == "y")//4yes
                {
                    Console.Write("You are a healthy person");
                }
                else//4no
                {
                    Console.Write("Try to do other exercises for other muscles of the body");
                }

            }
            else//3no
            {
                Console.Write("Anyway, exercising is very useful. keep going always");
            }
        }
        else//2no
        {
            Console.Write("Please at your free time do exercise and Always Eat green FOOD to better your all senses");
        }

    }
}


////4////
void FourthGroupQS()
{
    Console.Write("Do you know how to drive ? (y/n)  ");//1
    if (Console.ReadLine().ToLower() == "y")//1yes
    {
        Console.Write("Are you more than 18 years old ? (y/n) ");//2
        if (Console.ReadLine().ToLower() == "y")//2yes
        {
            Console.Write("You did your best to get a driver's license\nbecause it is a necessary thing for everyone\nDo you have a car?");//3
            if (Console.ReadLine().ToLower() == "y")//3yes
            {
                Console.Write("good\nDrive carefully... ");
            }
            else//3no
            {
                Console.Write("not important\nYou should try to buy a car in the future ");
            }
        }
        else//2no
        {
            Console.Write("Driving at your age is very dangerous\nyou must also have a driving license");
        }
    }
    else//1no
    {
        Console.Write("Are you more than 20 years old ? (y/n) ");//4
        if (Console.ReadLine().ToLower() == "y")//4yes
        {
            Console.Write("Well, maybe you didn't need to do it until now, but learn soon");
        }
        else//4no
        {
            Console.Write("Don't worry, you still have time");
        }
    }
}


////5////
void FifthGroupQS()
{
    Console.Write("Are you satisfied with this program ? (y/n) ");//1
    if (Console.ReadLine().ToLower() == "y")//1yes
    {
        Console.Write("Thank you for your satisfaction\nDo you have an idea to make it better ? (y/n) ");//2
        if (Console.ReadLine().ToLower() == "y")//2yes
        {
            Console.Write("Please tell us your opinion through (way of communication with us).");
        }
        else//2no
        {
            Console.Write("Thank you for using this program");
        }

    }
    else//1no
    {
        Console.Write("I will try to be satisfactory in the next updates\nBye Bye");
    }
}


////Lock_KEY////
void LockKeyboradYN()
{
    string answer;

    do
    {
        answer = Console.ReadKey(true).KeyChar.ToString();

    } while (answer.ToLower() != "y" && answer.ToLower() != "n" && answer != "1" && answer != "2" && answer != "3" && answer != "4" && answer != "5");
}
