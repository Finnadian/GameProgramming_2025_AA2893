using System;

public class HealthSystem 
{
    //no idea how Events work but they may be useful
    public event EventHandler OnDamaged;
    public event EventHandler OnDead;

    private int health;
    private int healthMax;
    public HealthSystem(int health)
    {
        this.healthMax = healthMax;
        health = healthMax;
    }

    public int GetHealth()
    {
        return health;
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 0) health = 0;
    }
    public void Heal(int healAmount) { 
        health += healAmount;
        if (health > healthMax) health = healthMax;
    }
}
