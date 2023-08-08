using System;
using System.Collections.Generic;


namespace CricketTeam
{
  public  class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

   public class CricketTeam
    {
        private List<Player> players;

        public CricketTeam()
        {
            players = new List<Player>();
        }

        public void AddPlayer(int playerId, string name, int age)
        {
            if (players.Count < 11)
            {
                players.Add(new Player { Id = playerId, Name = name, Age = age });
                Console.WriteLine($"Player {name} (ID: {playerId}) added to the team.");
            }
            else
            {
                Console.WriteLine("Cannot add more players. The team already has 11 players.");
            }
        }

        public void RemovePlayer(int playerId)
        {
            var playerToRemove = players.Find(p => p.Id == playerId);
            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);
                Console.WriteLine($"Player {playerToRemove.Name} (ID: {playerId}) removed from the team.");
            }
            else
            {
                Console.WriteLine($"Player with ID {playerId} not found in the team.");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            return players.Find(p => p.Id == playerId);
        }

        public Player GetPlayerByName(string name)
        {
            return players.Find(p => p.Name == name);
        }

        public List<Player> Display()
        {
            Console.WriteLine("Csk Player List:");
            foreach (var player in players)
            {
                Console.WriteLine($"Player {player.Name} (ID: {player.Id}), Age: {player.Age}");
            }
            return players;
        }
    }

}
   