using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AA2893 {
    class GameInventory : MonoBehaviour
    {
        //here list all the variables that are used for weapons
        private int hardness = 1;
        private int blugeon = 0;
        private int slash = 0;
        private int pierce = 0;
        private int reach = 1;

        string[] backPack = new string[10];
        /*private object createSword(int swordHardness, int swordBludgeon, int swordSlash, int swordPierce, int swordReach)
        {
            swordHardness = hardness;
            swordHardness = blugeon;
            swordSlash = slash;
            swordPierce = pierce;
            swordReach = reach;
            Debug.Log("The blade is forged");
        }
        */

        //have a single public thing that is referenced when adding or removing things from the inventory

        public void CheckInventory()
        {
            /*
            if (backPack != null) 
            { Debug.Log("Your bag is empty")}
            else { Debug.Log(message: "Your backpack contains atleast " + backPack[1] + backPack[2] + backPack[3] + backPack[4] + backPack[5]); }
            Console.WriteLine("Test");
            */
        }

        // Start is called before the first frame update
        private void Start()
        {

        }

        // Update is called once per frame
        private void Update()
        {

        }
    }
}
