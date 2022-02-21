using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyObject : MonoBehaviour
{
    public float speed;
    public int damage;

    private void Start()
    {
        transform.Rotate(0, 180, 0);
    }
    private void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Health>(out var Health))
        {
            Health.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
