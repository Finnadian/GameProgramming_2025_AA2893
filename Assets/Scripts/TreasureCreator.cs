using UnityEngine;
using static UnityEngine.Rendering.DebugUI;
namespace Jasper
{
    [System.Serializable]
    public class TreasureCreator : Stuff //inherits from Stuff
{

        [SerializeField] public int TreasureValue;
        [SerializeField] GameObject TargetTreasure;
        [SerializeField] GameObject boatCollider1;
        public Rigidbody rb; //to get the rigid body I think
        public AudioSource audioBreaking; //need for the sound of the thing when it takes damage
        [SerializeField] GameObject spawnCushion;

        public TreasureCreator() //default constructor
        {
            TreasureValue = 1;
        }
        public TreasureCreator(string ObjectName, int ObjectWeight, int ObjectDurability, int ObjectHealth, int TreasureValue) //constructor
        {
            this.ObjectName = ObjectName;
            this.ObjectWeight = ObjectWeight;
            this.ObjectDurability = ObjectDurability;
            this.ObjectHealth = ObjectHealth;
            this.TreasureValue = TreasureValue;
        }
        public void IntroduceTreasure()
        {
            Debug.Log(message: $"This is a {ObjectName} with a value of {TreasureValue}");
        }

        private void OnTriggerEnter(Collider boatCollider1)
        {
            SumScore.Add(TreasureValue);
            //Destroy(Treasure);
            Destroy(TargetTreasure.gameObject);
        }
        private void OnCollisionEnter(Collision collision)
        {

            if (collision.gameObject == boatCollider1)
            { /*
                SumScore.Add(TreasureValue);
                //Destroy(Treasure);
                Destroy(TargetTreasure.gameObject); */
            }
            else if (collision.gameObject == spawnCushion)
            {

            }
            else
            {
                ObjectHealth = ObjectHealth - ObjectDurability;
                Debug.Log(message: $"I took damage! I have {ObjectHealth} health left");
                TreasureValue = ObjectHealth;
                Debug.Log(message: $"I am still worth {TreasureValue}");

                if (TreasureValue < 1) {
                    Destroy(gameObject);
                    audioBreaking.Play();
                }
                audioBreaking.Play();
            }
        }

        private void Start()
        {
            rb = GetComponent<Rigidbody>(); //gets the rigid body mass and makes it equal to the weight
            rb.mass = ObjectWeight;
            //audioBreaking = GetComponent<AudioSource> (); //gets the audio from the component so it can be used
        }


        // Start is called once before the first execution of Update after the MonoBehaviour is created

    }
}
