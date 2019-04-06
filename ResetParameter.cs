using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResetParameter : MonoBehaviour
{
    Item items;
    Toriniku Chickens;
    Salmon salmons;
    // Start is called before the first frame update
    void Start()
    {
        items = GetComponent<Item>();
        Chickens = GetComponent<Toriniku>();
        salmons = GetComponent<Salmon>();
    }

    // Update is called once per frame
    void Update()
    {
        Item.RiceConuter = 0;
        Item.RiceBonus = 0;
        Toriniku.ChickenCounter = 0;
        Salmon.SalmonCounter = 0;
    }
}
