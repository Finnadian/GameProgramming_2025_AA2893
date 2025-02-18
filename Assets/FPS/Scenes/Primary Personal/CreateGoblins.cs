using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

namespace AA2893
{
    public class CreateGoblins : MonoBehaviour
    {           //CLASS

        public GameObject goblinMakingMachine;
        public GameObject goblinMan;


        public string goblinName = "DEFAULT";
        public int goblinColour = 1; //somewhere assign numbers to be colors?
        public int healthPoints = 6;
        public string meleeWeapon = "Short_Sword";

        //CONSTRUCTOR

        public CreateGoblins(string gruntName, int gruntHealth, string gruntWeapon)
        {
            goblinName = gruntName; //does this matter??
            healthPoints = gruntHealth;
            meleeWeapon = gruntWeapon;
            GameObject.Instantiate(goblinMan, transform.position, Quaternion.identity);
            Debug.Log("CreateGoblin Successful");

            /* OLD CODE NO LONGER USEFUL
             * goblinName = goblinName_;
            goblinColour = Random(soomething something);
            healthPoints = healthPoints_;
            meleeWeapon = meleeWeapon_;
            */

        }





        /*ADD GOBLIN BOSS LATER
         * public GoblinBoss(string bossName, int bossHealth, string bossWeapon)
        {
            goblinName=bossName;
            healthPoints = bossHealth;
            meleeWeapon=bossWeapon;
        }
        */



        public void Start()
        {

            Debug.Log("Start up successful");
            CreateGoblins goblinMan = new CreateGoblins("Kibble", 4, "Spear");
        }
        public void Update()
        {
        //Debug.Log("A new goblin emerges! Beware " + getGoblinName() + "!");
        }

        public string getGoblinName()
        {
            return goblinName;
            Debug.Log("getGoblinName successful");
        }



    }


    //OBJECT

}
