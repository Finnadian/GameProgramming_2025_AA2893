using UnityEngine;

public class DestructibleObject : MonoBehaviour, IDamageable
{
    private HealthSystem healthSystem;

    private void Awake()
    {
        healthSystem = new HealthSystem(100);
        healthSystem.OnDead += HealthSystem_OnDead;
    }
    
    private void HealthSystem_OnDead(object sender, System.EventArgs e)
    {
        Destroy(gameObject);
        Debug.Log("Destroyed!");
    }
    public void Damage(int damageAmount)
    {
        healthSystem.Damage(damageAmount);
    }


}
