using System;
public class NewItem
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