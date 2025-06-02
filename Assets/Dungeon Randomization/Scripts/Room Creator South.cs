using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class RoomCreatorSouth : RoomDetector
{
    //for each individual
    //North = 1
    //South = 2
    //East = 3
    //West = 4
    public int nodeType = 2;

    [SerializeField] public GameObject[] roomSouthPrefabs;
    [SerializeField] private GameObject newFloor;
    public SphereCollider sphereColliderCreate;

    void Awake()
    {
        nodeSouth = new Vector3(-0.4f, 0, 0); //DO NOT MOVE TO PARENT
        sphereColliderCreate = GetComponent<SphereCollider>();
        Instantiate(detectSignalCylinder, transform.position + nodeSouth, Quaternion.identity);
    }

    void OnEnable()
    {
        bool isAnotherRoomOverlapping = Physics.CheckSphere(transform.position + nodeSouth, sphereColliderCreate.radius, whatArePieces);

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

    private void SetMyRoomHere()
    {
        Debug.Log("Nobody here!");
        int roomRandomizer = Random.Range(0, roomSouthPrefabs.Length);
        Instantiate(roomSouthPrefabs[roomRandomizer], transform.position + nodeSouth, roomSouthPrefabs[roomRandomizer].transform.rotation);
        Debug.Log(message: $"Creating room {roomSouthPrefabs[roomRandomizer]}");
    }
}

