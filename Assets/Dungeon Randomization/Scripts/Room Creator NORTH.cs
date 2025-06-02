using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class RoomCreatorNORTH : RoomDetector
{
    //for each individual
    //North = 1
    //South = 2
    //East = 3
    //West = 4
    public int nodeType = 1;

    [SerializeField] public GameObject[] roomNorthPrefabs;
    [SerializeField] private GameObject newFloor;
    public SphereCollider sphereColliderCreate;

    void Awake()
    {
        nodeNorth = new Vector3(0.4f, 0.0f, 0.0f); //DO NOT MOVE TO PARENT
        sphereColliderCreate = GetComponent<SphereCollider>();
        Instantiate(detectSignalCylinder, transform.position + nodeNorth, Quaternion.identity);
    }

    void OnEnable()
    {
        bool isAnotherRoomOverlapping = Physics.CheckSphere(transform.position + nodeNorth, sphereColliderCreate.radius, whatArePieces);
        
        if (isAnotherRoomOverlapping)
        {
            RemoveMe();
        }
        else
        {
            SetMyRoomHere();
        }

        gameObject.SetActive(false);
        newFloor.SetActive(true);
        }

    private void SetMyRoomHere() //break this into child prefabs so that there are different nodes going in the same direction have different generations (i.e a Dungeon room with a node going West will make X rooms, while a Treasure room with a node going West will make Y rooms, therefore I would need at least two different nodes. Makes more pre-determined, but may be useful and can show skills)
    {
        Debug.Log("Nobody here!");
        int roomRandomizer = Random.Range(0, roomNorthPrefabs.Length);
        Instantiate(roomNorthPrefabs[roomRandomizer], transform.position + nodeNorth, roomNorthPrefabs[roomRandomizer].transform.rotation);
        Debug.Log(message: $"Creating room {roomNorthPrefabs[roomRandomizer]}");
    }
}

