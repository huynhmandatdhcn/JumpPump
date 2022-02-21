using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : Health
{
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        Immortal();
    }
    private void Immortal()
    {
        gameObject.layer = LayerMask.NameToLayer("Neutral");
        Invoke(nameof(Unimmortal), 3);
    }
    private void Unimmortal()
    {
        gameObject.layer = LayerMask.NameToLayer("Player");
    }
}
