using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class RoomCreatorWest : RoomDetector
{
    //for each individual
    //North = 1
    //South = 2
    //East = 3
    //West = 4
    public int nodeType = 4;

    [SerializeField] public GameObject[] roomWestPrefabs;
    [SerializeField] private GameObject newFloor;
    public SphereCollider sphereColliderCreate;

    void Awake()
    {
        nodeWest = new Vector3(0, 0, 0.4f); //DO NOT MOVE TO PARENT
        sphereColliderCreate = GetComponent<SphereCollider>();
        Instantiate(detectSignalCylinder, transform.position + nodeWest, Quaternion.identity);
    }

    void OnEnable()
    {
        bool isAnotherRoomOverlapping = Physics.CheckSphere(transform.position + nodeWest, sphereColliderCreate.radius, whatArePieces);

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
        int roomRandomizer = Random.Range(0, roomWestPrefabs.Length);
        Instantiate(roomWestPrefabs[roomRandomizer], transform.position + nodeWest, roomWestPrefabs[roomRandomizer].transform.rotation);
        Debug.Log(message: $"Creating room {roomWestPrefabs[roomRandomizer]}");
    }
}
