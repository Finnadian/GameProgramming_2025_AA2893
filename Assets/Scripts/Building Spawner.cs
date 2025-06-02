using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    public GameObject[] buildingPrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int buildingRandomizer = Random.Range(0, buildingPrefabs.Length);
        //Instantiate(buildingPrefabs[buildingRandomizer], transform.position, Quanternion rotation, transform.rotation);
        Instantiate(buildingPrefabs[buildingRandomizer], transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
