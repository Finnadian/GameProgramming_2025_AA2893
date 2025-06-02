using UnityEngine;

public class TreasureSpawner : MonoBehaviour
{
    public GameObject[] treasurePrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int treasureRandomizer = Random.Range(0, treasurePrefabs.Length);
        Instantiate(treasurePrefabs[treasureRandomizer], transform.position + new Vector3(0, 0.2f, 0), treasurePrefabs[treasureRandomizer].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {

            int treasureRandomizer = Random.Range(0, treasurePrefabs.Length);
            Instantiate(treasurePrefabs[treasureRandomizer], transform.position + new Vector3 (0,0.2f,0), treasurePrefabs[treasureRandomizer].transform.rotation);
        }
    }
}
