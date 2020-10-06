using System;
using System.Threading.Tasks;

public class MongoDbRepository : IRepository
{
    public Task<Item> CreateItem(Guid playerId, Item item)
    {
        try{
            foreach (var player in playersList)
            {
                if (player.Id == playerId)
                {
                    item = new Item();
                }
            }
        }
        catch{
            throw new NotImplementedException();
        }
    }

    public Task<Player> CreatePlayer(Player player)
    {
        try{
            player = new Player();
        }
        catch
        {
            throw new NotImplementedException();
        }
    }

    public Task<Item> DeleteItem(Guid playerId, Item item)
    {
        try{
            foreach (var player in playersList)
            {
                if (player.Id == playerId)
                {
                    DeleteItem(item);
                }
            }
        }
        catch{
            throw new NotImplementedException();
        }
    }

    public Task<Player> DeletePlayer(Guid playerId)
    {
        try{
            foreach (var player in playersList)
            {
                if (player.Id == playerId)
                {
                    DeletePlayer(player);
                }
            }
        }
        catch{
            throw new NotImplementedException();
        }
    }

    public Task<Item[]> GetAllItems(Guid playerId)
    {
        try{
            foreach (var item in itemsList)
            {
                    return item;
            }
        }
        catch{
            throw new NotImplementedException();
        }
    }

    public Task<Player[]> GetAllPlayers()
    {
        try{
            foreach (var player in playersList)
            {
                    return player;
            }
        }
        catch{
            throw new NotImplementedException();
        }
    }

    public Task<Item> GetItem(Guid playerId, Guid itemId)
    {
        try{
            foreach (var item in itemsList)
            {
                if (player.Id == playerId)
                {
                    if(item.id == itemId){
                        return item;
                    }
                }
            }
        }
        catch{
            throw new NotImplementedException();
        }
    }

    public Task<Player> GetPlayer(Guid playerId)
    {
        try{
            foreach (var player in playersList)
            {
                if (player.Id == playerId)
                {
                    return player;
                }
            }
        }
        catch{
            throw new NotImplementedException();
        }
    }

    public Task<Item> UpdateItem(Guid playerId, Item item)
    {
        try{
            foreach (var item in itemsList)
            {
                if (player.Id == playerId)
                {
                    if(item.id == itemId){
                        DeleteItem(item);
                        Item item2 = new Item();
                        return item2;
                    }
                }
            }
        }
        catch{
            throw new NotImplementedException();
        }
    }

    public Task<Player> UpdatePlayer(Player player)
    {
        try{
            foreach (var item in itemsList)
            {
                if (player.Id == playerId)
                {
                    DeletePlayer(player);
                    Player player2 = new Player();
                    return player2;
                }
            }
        }
        catch{
            throw new NotImplementedException();
        }
    }
}