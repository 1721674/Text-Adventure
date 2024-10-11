using System.ComponentModel.Design;

namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Traveler. Which door would you like to go in?");
            Console.WriteLine("RED|BLUE|YELLOW");

            string music;
            string setting;
            string difficulty;
            string mode;
            string player;
            string input = Console.ReadLine();
            if (input == "RED")
            {
                Console.WriteLine("You are about to play Party mode.");
                Console.WriteLine("How many opponents are you playing against?");
                Console.WriteLine("1|2|3");

                input = Console.ReadLine(); 
                if (input == "3")
                {
                    Console.WriteLine("Select character");
                    Console.WriteLine("Player A|Player B|Player C|Player D|Player E|Player F");
                    player = input;
                    input = Console.ReadLine();
                    if (input == "Player A")
                    Console.WriteLine("Select opponent difficulty");
                    Console.WriteLine("Easy|Normal|Hard|Very Hard|Master");
                    difficulty = input;
                    input = Console.ReadLine();
                    if (input == "Normal")
                        Console.WriteLine("Your opponents have been chossen.");
                    else if (input == "Easy")
                        Console.WriteLine("The beginer opponents will be chosen shorty.");
                    else if (input == "Master")
                        Console.WriteLine("The strongest opponents are being determented");
                    else if (input == "Hard")
                        Console.WriteLine("Opponents won't go easy on you.");
                    else if (input == "Very Hard")
                        Console.WriteLine("More experianced players will arive shortly.");
                }
                else if (input == "2") 
                {
                    Console.WriteLine("Select character");
                    Console.WriteLine("Player A|Player B|Player C|Player D|Player E|Player F");
                    player = input;
                    input = Console.ReadLine();
                    if (input == "Player B")
                    Console.WriteLine("Choose dificulty");
                    Console.WriteLine("Relaxing|Average|Demanding");
                    difficulty = input;
                    input = Console.ReadLine();
                    if (input == "Average")
                        Console.WriteLine("Opponents are ready.");
                    else if (input == "Relaxing")
                        Console.WriteLine("Opponents chosen.");

                }
                else if (input == "1")
                {
                    Console.WriteLine("Select character");
                    Console.WriteLine("Player A|Player B|Player C|Player D|Player E|Player F");
                    player = input;
                    input = Console.ReadLine();
                    if (input == "Player C")
                    Console.WriteLine("How difficult do you want your opponent to be?");
                    Console.WriteLine("Too hard|Too easy|Just right");
                    difficulty = input;
                    input = Console.ReadLine();
                    if (input == "Too hard")
                    Console.WriteLine("Your challanging opponent is being determented.");
                }
            }

            else if (input == "BLUE")
            {
                Console.WriteLine("You are entering the Settings");
                Console.WriteLine("What would you like to change?");
                Console.WriteLine("CPU Speed|Music Settings");
                setting = input;
                input = Console.ReadLine();
                if (input == "Music Settings");
                Console.WriteLine("Choose music type");
                Console.WriteLine("Classic|Normal|8-Bit");
                music = input;
                input = Console.ReadLine();
                if (input == "Classic")
                    Console.WriteLine("The music may sound familiar to you.");
                else if (input == "Normal")
                    Console.WriteLine("The music is set to normal");
                else if (input == "8-bit")
                    Console.WriteLine("The music will sound like you are playing NES games like 'Super Mario Bros'");
            }

            else if (input == "YELLOW")
            {
                Console.WriteLine("You are about to enter the Bouns Games.");
                Console.WriteLine("Choose a game");
                Console.WriteLine("Free Play|Step it Up|Perspective Mode|Spot the Sneak|Time Atack|Puzzle Mode");
                mode = input;
                input = Console.ReadLine();
                if (input == "Free Play")
                Console.WriteLine("Choose a character");
                Console.WriteLine("Player A|Player B|Player C|Player D|Player E|Player F");
                player = input;
                input = Console.ReadLine();
                if (input == "Player D")
                Console.WriteLine("How dificult will your opponents be?");
                Console.WriteLine("Casual|Classic|Challanging");
                difficulty = input;
                input = Console.ReadLine();
                if (input == "Classic")
                    Console.WriteLine("Have fun in Free Play!");
                else if (input == "Casual")
                    Console.WriteLine("Looks like you want a relaxing experience, anyway have fun in Free Play.");
                else if (input == "Challanging")
                    Console.WriteLine("Up for a challange? Well, good luck!");
            }
        }
    }
}
