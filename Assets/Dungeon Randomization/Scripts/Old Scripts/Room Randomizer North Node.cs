using UnityEditor;
using UnityEngine;

public class RoomRandomizerNorthNode : MonoBehaviour
{
    
        public GameObject[] roomNorthPrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //if nothing, create the room and destroy the node
        int roomRandomizer = Random.Range(0, roomNorthPrefabs.Length);
        Instantiate(roomNorthPrefabs[roomRandomizer], transform.position + new Vector3(0.5f, 0, 0), roomNorthPrefabs[roomRandomizer].transform.rotation);
        Debug.Log(message: $"Creating room {roomNorthPrefabs}");

        //if something, destroy the node
        
    }

    // Update is called once per frame
    void Update()
        {

        }
    
}
