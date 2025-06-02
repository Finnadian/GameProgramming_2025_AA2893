using System.Runtime.CompilerServices;
using UnityEngine;
namespace Jasper

{
    [System.Serializable]
    public class Stuff : MonoBehaviour
    {
        protected string ObjectName; //must be private or protected to be accessed in derived class
        [SerializeField] public int ObjectWeight;
        [SerializeField] public int ObjectDurability;
        [SerializeField] public int ObjectHealth;

        public Rigidbody rb; //to get the rigid body I think

        public Stuff() //default constructor
        {
            ObjectName = "N/A";
            ObjectWeight = 1;
            ObjectDurability = 1;
            ObjectHealth = 1;
        }
        public Stuff(string ObjectName, int ObjectWeight, int ObjectDurability, int ObjectHealth) //constructor
        {
            this.ObjectName = ObjectName;
            this.ObjectWeight = ObjectWeight;
            this.ObjectDurability = ObjectDurability;
            this.ObjectHealth = ObjectHealth;
        }
        public void IntroduceObject()
        {
            Debug.Log(message: $"This is a {ObjectName} with a weight of {ObjectWeight}");
        }
        private void OnCollisionEnter(Collision collision)
        {
                ObjectHealth = ObjectHealth - ObjectDurability;
                Debug.Log(message: $"I took damage! I have {ObjectHealth} health left");
                if (ObjectHealth < 1) { Destroy(gameObject); }
        }

        private void Start()
        {
            rb = GetComponent<Rigidbody>(); //gets the rigid body mass and makes it equal to the weight
            rb.mass = ObjectWeight;
        }

    }

}












    //ALL BELOW IS OLD CODE, USE STUFF class and TREASURECREATOR script which inherits from STUFF
    /*
public class Treasure
{
    //constructors to initialize a class Treasure is Tres
    //act like functions that create an object of the class being implemented(?)
    public Treasure(string TresName, int TresHealth, int TresDurability, int TresWeight, int TresValue)
    {
        TresName = "Goblet";
        TresHealth = 0;
        TresDurability = 0;
        TresWeight = 0;
        TresValue = 0;


        void IntroduceTreasureOUTDATED()
        {
            Debug.Log("This is a " + TresName + " with a weight of " + TresWeight + " and a value of " + TresValue);
        }
    }
}

public class JunkFixed
    {
     public JunkFixed(string JunkName, int JunkHealth, int JunkDurability, int JunkWeight)
        {
            JunkName = "Table";
            JunkHealth = 0;
            JunkDurability = 0;
            JunkWeight = 0;

        void IntroduceJunk()
        {
            Debug.Log(message:$"This is a " + JunkName + " with a weight of {JunkWeight} and a durability of {JunkDurability}");
        }
    }

    }
    */









    

