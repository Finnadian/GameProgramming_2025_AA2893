using UnityEngine;

public class Night : MonoBehaviour
{
    private GameObject human;

    private void PutEverybodyToSleep()
    {
        Sleep sleep = human.GetComponent<Sleep>();

        if(sleep != null )
        {
            sleep.GetSleep();
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
