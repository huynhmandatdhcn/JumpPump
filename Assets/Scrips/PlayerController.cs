using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public Transform[] waypoints;
    public float speed = 1;
   
    void Start()
    {
        anim.SetBool("isRun", true);  
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            MoveTowards(waypoints[0].position);
            IsJumping();
        }
        else
        {
            MoveTowards(waypoints[1].position);
            if (transform.position == waypoints[1].position)
            {
                IsRunning();
            }
        }
    }
    private void MoveTowards(Vector2 destination)
    {
        transform.position = Vector2.MoveTowards(transform.position, destination, speed * Time.deltaTime);
    }
    public void IsJumping()
    {
        anim.SetBool("isRun", false);
        anim.SetBool("isJump", true);
    } 
    public void IsRunning()
    {
        anim.SetBool("isRun", true);
        anim.SetBool("isJump", false);
    }
    
}
