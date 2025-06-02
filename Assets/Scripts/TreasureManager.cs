using UnityEditor;
using UnityEngine;
namespace Jasper
{
    [System.Serializable]
    
    public class TreasureManager : MonoBehaviour
    {
        public TreasureCreator[] treasureTest1;//exists so can modify values in the Unity interface, but atm it is not working

        public void Start()
        {

            var treasure0 = new TreasureCreator();
            var treasure1 = new TreasureCreator(ObjectName:"Goblet",ObjectWeight: 1, ObjectDurability: 1, ObjectHealth: 100, TreasureValue: 100);
            var treasure2 = new TreasureCreator(ObjectName: "Amulet", ObjectWeight: 1, ObjectDurability: 1, ObjectHealth: 5, TreasureValue:5);
            var treasure3 = new TreasureCreator(ObjectName: "Ring", ObjectWeight: 1, ObjectDurability: 1, ObjectHealth: 10, TreasureValue: 10);

            treasure1.IntroduceTreasure();

            treasureTest1[0].IntroduceTreasure();
        }

    }
   
}

