using System;
using System.Collections.Generic;

public class Player : IPlayer
{
    public Guid Id { get; set; }
    public int Score { get; set; }
    public static List<Item> Items { get; set; }

    public Player(){
        Id = Guid.NewGuid();
    }

    public void biggestItem(){
        
        public Item bI = Items[0];

        for(int i = 0; i < Items.Count; i++){
            if(Items[i] > bI)
                bI = Items[i];
        }

        return bI;
    }

}