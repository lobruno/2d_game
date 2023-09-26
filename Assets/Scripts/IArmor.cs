public interface IArmor
{
    float CurrentArmor { get; }  // The current amount of armor
    float MaxArmor { get; }      // The maximum amount of armor

    void TakeArmorDamage(float damage); // Method for taking armor damage
}

