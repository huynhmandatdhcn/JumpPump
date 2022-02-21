using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(AnimController))]
public class Health : MonoBehaviour
{
    public int health;
    public AnimController animController;
    public UnityEvent takingDamage;
    public UnityEvent OnDie;
    public MoveByKey moveByKey;
    void OnValidate()
    {
        animController = GetComponent<AnimController>();
        OnDie.AddListener(animController.Die);
        takingDamage.AddListener(animController.Hurt);
    }
    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die(); 
        }
        takingDamage.Invoke();
    }
    
    void Die()
    {
        OnDie.Invoke();
        Destroy(gameObject,2f);
    }
}
