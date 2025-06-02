using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEngine.ParticleSystem;
namespace Jasper
{

    public class DecectCollissions : MonoBehaviour 
    {
        [SerializeField] GameObject boatCollider1;
        [SerializeField] GameObject Treasure;
        [SerializeField] int Value;

        private void OnTriggerEnter(Collider boatCollider1)
        {
            SumScore.Add(Value);
            //Destroy(Treasure);
            Destroy(Treasure.gameObject, 1);


        }
        private void onCollisionEnter (Collision collision)
        { //later fix this to work with tags and not objects, because I think it would make it easier (i.e anything with terrain tag, instead of having to define all terrain objects individually)
            if (collision.gameObject == boatCollider1)
            {
                SumScore.Add(Value);
                //Destroy(Treasure);
                Destroy(Treasure.gameObject);
            }
            //no idea if this one works, added from CodeMonkey tutorial
            if (collision.gameObject.TryGetComponent<IDamageable>(out IDamageable damageable))
            {
                damageable.Damage(10);
            }
            else if (collision.gameObject)
            {
                Destroy(Treasure.gameObject);
            }



        }


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        public void Start()
        {
        }

        public class CollisionSensor : TreasureCreator
        {

            void OnTriggerEnter(Collider boatCollider1)
            {
                int value = TreasureValue;
                SumScore.Add(value);
                SumScore.Add(500);
                Debug.Log(message: $"You Gain {TreasureValue}");
                //add treasure value to score system
            }
        }
    }
    }

        
    
    

   
    // Update is called once per frame
    
        


