using System;
using System.Runtime.Remoting.Services;


namespace CricketTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CricketTeam team = new CricketTeam();
        start:
            Console.WriteLine("Welcome Selectors in CSK Selection List");
            Console.WriteLine("Would You Like TO Move Forward(y/n");
          string exp= Console.ReadLine();
          exp=  exp.ToLower();
            if (exp == "y")
            {
                Console.WriteLine("Press 1 For Display Player List");
                Console.WriteLine("Press 2 For REmove Player from List");
                Console.WriteLine("Press 3 For Add Player into List");
                Console.WriteLine("Press 4 For Display Player Details By ID");
                Console.WriteLine("Press 5 For Get Player By Name");
             int sw =  int.Parse(Console.ReadLine());
                switch(sw)
                {
                    case 1:
                        Console.WriteLine("Csk Player List");
                        team.Display();
                        break;
                    case 2:
                        Console.WriteLine("Want to Remove Player from List");
                        team.Display();
                        Console.WriteLine("Enter Player ID");
                        int player = int.Parse(Console.ReadLine());

                        team.RemovePlayer(player);
                       
                        break;
                    case 3:
                        Console.WriteLine("Want to Add Player");
                        Console.WriteLine("Enter Player ID");
                        int playerid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Player Name");
                        string playername = Console.ReadLine();
                        Console.WriteLine("Enter Player Age");
                        int playerage= int.Parse(Console.ReadLine());

                        team.AddPlayer(playerid,playername,playerage);
                        Console.WriteLine("Updated List");
                        team.Display();
                        break;
                    case 4: Console.WriteLine("want to check players details by ID, Enter Player ID first");
                        int idsearch = int.Parse(Console.ReadLine());
                        team.GetPlayerById(idsearch);
                        break;

                    case 5:
                        Console.WriteLine("want to check players details by name, Enter Player ID first");
                        string namesearch = Console.ReadLine();
                        team.GetPlayerByName(namesearch);
                        break;
                    default: Console.WriteLine("Invalid key");
                        Console.WriteLine("want to go to to main list, press y otherwise any key");
                        string p = Console.ReadLine();
                        p = p.ToLower();
                        if (p == "y")
                        {
                            goto start;
                        }
                        break;
                    }
                Console.WriteLine("want to go to to main list, press y otherwise any key");
                string g = Console.ReadLine();
                g = g.ToLower();
                if (g == "y")
                {
                    goto start;
                }
                

            }


        }
    }
}
