public interface IHealth
{
    float CurrentHealth { get; } // The current health
    float MaxHealth { get; }     // The maximum health

    void TakeDamage(float damage); // Method for taking damage
    void Heal(float amount);       // Method for healing
}

