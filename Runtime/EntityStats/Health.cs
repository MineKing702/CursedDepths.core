using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHp = 100;
    [SerializeField] private int currentHp = 100;

    public void AddHealth(int amount)
    {
        currentHp = Mathf.Min(currentHp + amount, maxHp);
    }

    public void DealDamage(int toSub)
    {
        CurrentHp = Mathf.Max(currentHp - toSub, 0);

        if (currentHp <= 0)
        {
            GameEvents.PlayerDied();
        }
    }
}
