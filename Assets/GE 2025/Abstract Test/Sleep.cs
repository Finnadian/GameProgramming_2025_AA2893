using UnityEngine;

public abstract class Sleep : MonoBehaviour
{
    public bool sleep;
    public void GetSleep()
    {
        //inherited organism will sleep when this is called
        //maybe at some point put a check before running the method as to IF the thing can be put to sleep (i.e plants dont sleep)
        sleep = true;
        Debug.Log("Good Night");
    }

    public void WakeUp()
    {
        sleep = false;
        Debug.Log("I'm Awake");
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
