using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(AnimController))]
public class Shoot : MonoBehaviour
{
    public Bullet bulletPrefabs;
    public AnimController animController;
    public float interval;
    public UnityEvent shooting;

    private float lastTimeShoot;

    void OnValidate()
    {
        animController = GetComponent<AnimController>();
        shooting.AddListener(animController.Attack);
    }
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time - lastTimeShoot >= interval)
        {
            Instantiate(bulletPrefabs,transform.position,Quaternion.identity);
            lastTimeShoot = Time.time;
            shooting.Invoke();
        }
    }
}
