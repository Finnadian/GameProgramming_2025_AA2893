using UnityEditor;
using UnityEngine;

public class PlayerGroundCheck : MonoBehaviour
{
    PlayerController playerController;

    private void Awake()
    {
        playerController = GetComponentInParent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerController.gameObject)
            return; //this repeated is so that it doesnt consider the player as a valid collision basically

        //Debug.Log(message: $"Ground Touched");
        playerController.SetGroundedState(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == playerController.gameObject)
            return; 

        playerController.SetGroundedState(false);  
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == playerController.gameObject)
            return;

        //Debug.Log(message: $"Ground Touched");
        playerController.SetGroundedState(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == playerController.gameObject)
            return; //this repeated is so that it doesnt consider the player as a valid collision basically

        //Debug.Log(message: $"Ground Touched");
        playerController.SetGroundedState(true);
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == playerController.gameObject)
            return;

        playerController.SetGroundedState(false);
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject == playerController.gameObject)
            return;
        //Debug.Log(message: $"Ground Touched");
        playerController.SetGroundedState(true);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
