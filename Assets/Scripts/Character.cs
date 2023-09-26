using UnityEngine;

public class Character : MonoBehaviour, IHealth, IArmor
{
    // Implementation of the IHealth interface
    public float CurrentHealth { get; private set; }
    public float MaxHealth { get; private set; }

    public void TakeDamage(float damage)
    {
        // Implementation of taking damage
    }

    public void Heal(float amount)
    {
        // Implementation of healing
    }

    // Implementation of the IArmor interface
    public float CurrentArmor { get; private set; }
    public float MaxArmor { get; private set; }

    public void TakeArmorDamage(float damage)
    {
        // Implementation of taking armor damage
    }
}

