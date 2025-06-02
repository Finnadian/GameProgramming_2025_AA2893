using UnityEngine;

public class HealthSystemGameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HealthSystem healthSystem = new HealthSystem(100);
        Debug.Log("Health: " + healthSystem.GetHealth());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
