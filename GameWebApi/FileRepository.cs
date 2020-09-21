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

    Task<Player> IRepository.GetPlayer(Guid id)
    {
        throw new NotImplementedException();
    }

    Task<Player[]> IRepository.GetAllPlayers()
    {
        Player[] players;
        string playersString;
        string path = "";

        playersString = File.ReadAllText(path);
        PlayersList = JsonConvert.DeserializeObject<Player>(playersString);

    }

    async Task<Player> IRepository.CreatePlayer(Player player)
    {
        string path = @"c:\temp\game-dev-players.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(player));
        }

        return player;
        throw new NotImplementedException();
    }

    Task<Player> IRepository.UpdatePlayer(Player player)
    {
        throw new NotImplementedException();
    }

    Task<Player> IRepository.DeletePlayer(Guid id)
    {
        throw new NotImplementedException();
    }

    Task<Item> IRepository.GetItem(Guid playerId, Guid itemId)
    {
        throw new NotImplementedException();
    }

    Task<Item[]> IRepository.GetAllItems(Guid playerId)
    {
        Item[] items;
        string itemsString;
        string path = "";

        itemsString = File.ReadAllText(path);
        itemsList = JsonConvert.DeserializeObject<Player>(itemsString);
    }

    async Task<Item> IRepository.CreateItem(Guid playerId, Item item)
    {
        string path = @"c:\temp\game-dev-items.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(item));
        }

        return item;
        throw new NotImplementedException();
    }

    Task<Item> IRepository.UpdateItem(Guid playerId, Item item)
    {
        throw new NotImplementedException();
    }

    Task<Item> IRepository.DeleteItem(Guid playerId, Item item)
    {
        throw new NotImplementedException();
    }
}
public class PlayersList{
    public List<Player> players { get; set; }
}
public class ItemsList{
    public List<Item> items { get; set; }
}