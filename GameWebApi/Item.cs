using System;
public class Item
{
    int Level;
    enum ItemType
    {
        SWORD,
        POTION,
        SHIELD
    }
    DateTime CreationDate = DateTime.Now;
}