using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBagManager : MonoBehaviour
{
    public ArrayList bag;
    // Start is called before the first frame update
    void Start()
    {
        bag = new ArrayList();
    }

    public void AddItem(Item item)
    {
        bag.Add(item);
    }

    public Item GetItem(int slot)
    {
        return bag[slot] as Item;
    }

    public Item[] GetBagContents()
    {
        return bag.ToArray() as Item[];
    }
}