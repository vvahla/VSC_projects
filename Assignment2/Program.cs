using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {

        public static void InstantiatePlayers(int amount){

            Player[] players = new Player[amount];

            for(int i = 0; i < amount; i++){
                players[i] = new Player();
                players[i].Id = Guid.NewGuid();
            }

            Guid[] ids = new Guid[amount];

            for(int i = 0; i < amount; i++){
                
                if(i > 0){
                    int pos = Array.IndexOf(ids, players[i].Id);

                    if(pos == -1){
                        ids[i] = players[i].Id;
                    }
                    else{
                        Console.WriteLine("Tuplat :D");
                    }
                }
                else{
                    ids[i] = players[i].Id;
                }
            }

        }

        static void Main(string[] args)
        {
            InstantiatePlayers(100000);
        }

    }
}
