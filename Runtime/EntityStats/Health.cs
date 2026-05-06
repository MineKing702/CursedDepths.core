using UnityEngine;
using CursedDepths.Core.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHp = 100;
    [SerializeField] private int currentHp = 100;
    [SerializeField] private bool isPlayer;

    public void AddHealth(int amount)
    {
        currentHp = Mathf.Min(currentHp + amount, maxHp);
    }

    public void DealDamage(int toSub)
    {
        currentHp = Mathf.Max(currentHp - toSub, 0);

        if (currentHp <= 0)
        {
            EntityDiedEventArgs arg = new EntityDiedEventArgs();
            arg.id = isPlayer ? EntityDiedEventArgs.EntityID.Player : EntityDiedEventArgs.EntityID.Enemy;
            arg.level = 0;
            GameEvents.EntityDied(arg);
        }
    }
}
