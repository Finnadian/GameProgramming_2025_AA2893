using System.Collections.Specialized;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class RoomCreatorEAST : RoomDetector
{
    //for each individual
    //North = 1
    //South = 2
    //East = 3
    //West = 4
    public int nodeType = 3;

    [SerializeField] public GameObject[] roomEastPrefabs;
    [SerializeField] private GameObject newFloor;
    public SphereCollider sphereColliderCreate;

    void Awake()
    {
        nodeEast = new Vector3(0, 0, -0.4f); //DO NOT MOVE TO PARENT
        sphereColliderCreate = GetComponent<SphereCollider>();
        Instantiate(detectSignalCylinder, transform.position + nodeEast, Quaternion.identity);
    }

    void OnEnable()
    {
        bool isAnotherRoomOverlapping = Physics.CheckSphere(transform.position + nodeEast, sphereColliderCreate.radius, whatArePieces);

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
        int roomRandomizer = Random.Range(0, roomEastPrefabs.Length);
        Instantiate(roomEastPrefabs[roomRandomizer], transform.position + nodeEast, roomEastPrefabs[roomRandomizer].transform.rotation);
        Debug.Log(message: $"Creating room {roomEastPrefabs[roomRandomizer]}");
    }
}

