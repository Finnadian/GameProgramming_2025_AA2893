using UnityEngine;

public class Rubble : MonoBehaviour
{
    [SerializeField] private bool isRubbleOverlap = false;
    [SerializeField] private LayerMask whatArePieces;
    [SerializeField] private SphereCollider sphereColliderCreate;
    [SerializeField] public GameObject[] rubbleWallPrefabs;
    //[SerializeField] public GameObject[] roomEastPrefabs;
    //[SerializeField] private GameObject newFloor;

    private void Awake()
    {
        sphereColliderCreate = GetComponent<SphereCollider>();
    }

    void OnEnable()
    {
        bool ísRubbleOverlap = Physics.CheckSphere(transform.position, sphereColliderCreate.radius, whatArePieces);

        if (ísRubbleOverlap)
        {
            SetWall(); 
        }
        else
        {
            LeaveRubble();
        }

        /*
        //from last script, not sure if neeeded??
        gameObject.SetActive(false);
        newFloor.SetActive(true);
        */
    }

    private void SetWall()
    { //taken from room generated in the East
        Debug.Log("Lots of Rubble Makes A Wall!");
        int roomRandomizer = Random.Range(0, rubbleWallPrefabs.Length);
        Instantiate(rubbleWallPrefabs[roomRandomizer], transform.position + new Vector3(0, 0, 0), rubbleWallPrefabs[roomRandomizer].transform.rotation);
        Debug.Log(message: $"Placing Wall {rubbleWallPrefabs[roomRandomizer]}");
    }

    private void LeaveRubble()
    {
        Debug.Log("The Rubble Remains...");
    }
}

    //on collision, if collides with rubble, becomes a wall
    //works the same way as the node spawner, but on awake, if collides with rublle, becomes a wall, otherwise remains a rubble

