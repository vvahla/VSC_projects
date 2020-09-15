using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
public class FileRepository : IRepository
{

static PlayersList playersList;
/*
    public void ReadFromFile(){
        string path = @"c:\temp\game_dev.txt";
        // Open the file to read from.
        using (StreamReader sr = File.OpenText(path))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
    */

    Task<Player> IRepository.Get(Guid id)
    {
        throw new NotImplementedException();
    }

    Task<Player[]> IRepository.GetAll()
    {
        Player[] players;
        string playersString;
        string path = "";

        playersString = File.ReadAllText(path);
        PlayersList = JsonConvert.DeserializeObject<Player>(playersString);

        foreach(var player in playersList.players){
            players
        }
    }

    async Task<Player> IRepository.Create(Player player)
    {
        string path = @"c:\temp\game-dev.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(player));
        }

        return player;
        throw new NotImplementedException();
    }

    Task<Player> IRepository.Modify(Guid id, ModifiedPlayer player)
    {
        throw new NotImplementedException();
    }

    Task<Player> IRepository.Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}
