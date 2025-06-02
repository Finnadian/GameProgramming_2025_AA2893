using UnityEngine;

public class GravityGunScript : MonoBehaviour
{
    
    //taken from https://www.youtube.com/watch?v=O93dev7l5Vg

    [SerializeField] Camera cam;
    [SerializeField] float maxGrabDistance = 1000f, throwForce = 20f, lerpSpeed = 10f;
    [SerializeField] Transform objectHolder;
    [SerializeField] float grabbedMass; //take the mass of the object you pick up

    Rigidbody grabbedRB;

    void Start()
    {

    }
    void Update()
    {
        if (grabbedRB)
        {
            grabbedRB.MovePosition(Vector3.Lerp(grabbedRB.position, objectHolder.transform.position, Time.deltaTime * (lerpSpeed - grabbedMass))); //!!!I tried doing lerpSpeed - grabbedMass but I could no longer move items, even changing lerpSpeed to 100 doesnt seem to make it faster after removing the subtraction. Try again, and check that the prefabs and character were updated in the game
            //!!!I need to fetch the mass of the object being interacted with, 

            if (Input.GetMouseButtonDown(0))
            {
                grabbedRB.isKinematic = false;
                grabbedRB.AddForce(cam.transform.forward * throwForce, ForceMode.VelocityChange);
                grabbedRB = null;
            }
        }

        if (Input.GetKeyDown(KeyCode.E)) //can move stuff with a rigid body (E to grab, E to drop)
        {
            if (grabbedRB)
            {
                grabbedRB.isKinematic = false;
                grabbedRB = null;
                grabbedMass = 0; //my code, resets grabbedMass to 0 when letting go of an object
            }
            else
            {
                RaycastHit hit;
                Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f)); //Sets how close the object is to the player
                if (Physics.Raycast(ray, out hit, maxGrabDistance))
                {
                    grabbedRB = hit.collider.gameObject.GetComponent<Rigidbody>();
                    if (grabbedRB)
                    {
                        grabbedRB.isKinematic = true;

                        grabbedMass = hit.collider.gameObject.GetComponent<Rigidbody>().mass; //!!!!taking player mass. Make it take object mass
                        Debug.Log(message: $"Grabbed Object has a mass of {grabbedMass}");
                    }
                }
            }
        }
    }
    
}
