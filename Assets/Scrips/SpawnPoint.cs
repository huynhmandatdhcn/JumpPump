using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnPoint : MonoBehaviour
{
    public GameObject flyObject;
    public float interval;
    public float minInterval;
    public float maxInterval;
    private float lastSpawnTime;

    private void Update()
    {
        if (Time.time - lastSpawnTime >= interval)
        {
            SpawnFlyObject();
            lastSpawnTime = Time.time;
        }
    }

    private void SpawnFlyObject()
    {
        Instantiate(flyObject, transform.position, Quaternion.identity);
    }
}
