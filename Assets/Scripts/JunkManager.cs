using UnityEditor;
using UnityEngine;
namespace Jasper

{

    [System.Serializable]
    public class JunkManager : MonoBehaviour
    {

        public Stuff[] things;//exists so can modify values in the Unity interface, but atm it is not working

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            //1st way to initialize
            /*
            var Object1 = new Stuff();

            Object1.ObjectName = "Chair";
            Object1.ObjectWeight = 1;
            Object1.ObjectDurability = 1;
            Object1.ObjectHealth = 1;

            //2nd way to initialize
            var Object2 = new Stuff()
            {
                ObjectName = "Table",
                ObjectWeight = 1,
                ObjectDurability = 1,
                ObjectHealth = 1
            };
            */

            //3rd way to initialize, CONSTRUCTORS!!, these tell the Contrsuctor in the Class what to make
            var object0 = new Stuff();
            var object1 = new Stuff(ObjectName: "Chair", ObjectWeight: 1, ObjectDurability: 1, ObjectHealth: 1);
            var object2 = new Stuff(ObjectName: "Table", ObjectWeight: 2, ObjectDurability: 2, ObjectHealth: 2);
            var object3 = new Stuff(ObjectName: "Barrel", ObjectWeight: 1, ObjectDurability: 1, ObjectHealth: 1);

            object2.IntroduceObject();
        }
        void Update()
        {

        }

    }
}

