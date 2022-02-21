using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public Transform[] backgrounds;
    public float speed;

    private float bgSpace;
    private void Start()
    {
        bgSpace = backgrounds[1].position.x - backgrounds[0].position.x;
        //Debug.Log(bgSpace);
    }
    private void Update()
    {
        for (int i = 0; i < backgrounds.Length; i++)
        {
            backgrounds[i].transform.Translate(-speed * Time.deltaTime,0,0);
            if (backgrounds[i].position.x < -bgSpace)
            {
                backgrounds[i].Translate(bgSpace * 2, 0, 0);
            }
        }
    }
}
