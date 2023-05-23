using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Striker
            {
                Name = "Николай Михайлов",
                Number = 1,
                Age = 25,
                Height = 180
            };
            var player2 = new Defender
            {
                Name = "Георги Иванов",
                Number = 4,
                Age = 28,
                Height = 185
            };
            var coach = new Coach
            {
                Name = "Елин Топузаков ",
                Age = 45
            };
            var coach2 = new Coach
            {
                Name = "Борис Василев",
                Age = 40
            };
            var team1 = new Team
            {
                Coach = coach,
                Players = new List<FootballPlayer> { player1, player2 }
            };
            var referee = new Referee
            {
                Name = "Станислав Тодоров",
                Age = 35
            };
            var referee2 = new Referee
            {
                Name = "Николай Йорданов Колев",
                Age = 48
            };
            var game = new Game
            {
                Team1 = team1,
                Referee = referee,
                AssistantReferees = new List<string> { "Иво Николаев Колев", "Мартин Емилов Венев" },
                Goals = new List<Tuple<int, FootballPlayer>>(),
                Result = string.Empty,
                Winner = string.Empty
            };

            game.Goals.Add(new Tuple<int, FootballPlayer>(15, player1));
            game.Goals.Add(new Tuple<int, FootballPlayer>(30, player2));
            game.Result = "0-9";
            game.Winner = "Левски София";
            Console.Write("резултат:");
            Console.WriteLine($"Левски София: {game.Team1.Coach.Name},{game.Winner}");
            Console.WriteLine($"ПФК Левски София: {game.Referee.Name}");
            foreach (var goal in game.Goals)
            {
                Console.WriteLine($"Минити: {goal.Item1}, Играч: {goal.Item2.Name}");
            }
            Console.WriteLine($"Резултат: {game.Result}");

            //Coach coach1 = new Coach("John", 45);
            //Goalkeeper goalkeeper1 = new Goalkeeper("David", 30, 1, 6.2);
            //Defender defender1 = new Defender("Michael", 28, 4, 5.11);
            //Midfield midfield1 = new Midfield("Daniel", 26, 8, 5.9);
            //Striker striker1 = new Striker("Robert", 27, 9, 6.0);

            //Team team1 = new Team(coach1);
            //team1.Players.Add(goalkeeper1);
            //team1.Players.Add(defender1);
            //team1.Players.Add(midfield1);
            //team1.Players.Add(striker1);
            //Referee referee = new Referee("Mark", 40);
            //Game game1 = new Game(team1, null, referee);
            //game1.Goals.Add(new Goal { Minute = 15, Player = "Daniel" });
            //game1.Goals.Add(new Goal { Minute = 30, Player = "Robert" });
            //game1.Result = "3-1";
            //game1.Winner = "Team 1";
            //game1.PrintResult();
        }
    }
    
}
