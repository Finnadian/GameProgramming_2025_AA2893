using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AA2893 { 
public class PlayerManager : MonoBehaviour
{

    private class Weapon
    {
        public int weaponDamage;
        public string weaponName;

        public String Name
        {
            get { return weaponName; }
            set { weaponName = value; }
        }
    }

    public string lootDrop;
    string[] backPack = new string[10];

    private String Loot
    {
        get { return lootDrop; }
        set { lootDrop = value; }
    }

    public Array Inventory
    {
        set { backPack[10] = lootDrop; }
    }

    // Start is called before the first frame update
    void Start()
    {
        //CheckInventory();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
}
