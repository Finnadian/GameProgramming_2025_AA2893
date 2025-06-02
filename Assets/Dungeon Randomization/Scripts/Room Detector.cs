using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class RoomDetector : MonoBehaviour
{
    private bool isAnotherRoomOverlapping = false;
    [SerializeField] public LayerMask whatArePieces;
    [SerializeField] public GameObject detectSignalCylinder;

    public Vector3 nodeNorth;
    public Vector3 nodeSouth;
    public Vector3 nodeEast;
    public Vector3 nodeWest;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Awake()
    {

        /*nodeNorth = new Vector3(0.4f, 0.0f, 0.0f);
        nodeEast = new Vector3(0.0f, 0.0f, 0.0f);
        nodeWest = new Vector3(0, 0, 0.4f);*/

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RemoveMe()
    {
        Debug.Log("Something is already here!");
    }

}
