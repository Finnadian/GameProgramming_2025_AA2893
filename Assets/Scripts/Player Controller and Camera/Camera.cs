using UnityEngine;

public class CameraMove : MonoBehaviour
{


    private const float YMin = -50.0f;
    private const float YMax = 50.0f;

    public Transform lookAt;

    public Transform Player;

    public float distance = 10.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    public float sensivity = 4.0f;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void LateUpdate()
    {

        currentX += Input.GetAxis("Mouse X") * sensivity * Time.deltaTime;
        currentY += Input.GetAxis("Mouse Y") * sensivity * Time.deltaTime;

        currentY = Mathf.Clamp(currentY, YMin, YMax);

        Vector3 Direction = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        transform.position = lookAt.position + rotation * Direction;

        transform.LookAt(lookAt.position);



    }
    /*
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player;
    private Vector3 cameraOffset = new Vector3(0, 8, -16);

    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate() //this does the update AFTER normal update, ensuring that the camera only moves after the vehicle moves. Otherwise it might move out of sync
    {
        // Offeset the camera behind the player by adding to the players position
        transform.position = player.transform.position + cameraOffset;
       
    }
    */
}


