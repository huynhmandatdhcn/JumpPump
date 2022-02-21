using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByKey : MonoBehaviour
{
    public float speedRun;
    public float jumpHight;
    public Rigidbody2D rigid;
    public LayerMask layerMask;
    private void OnValidate()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMoving();
        UpdateJump();
        UpdateFacing();
    }

    private void UpdateMoving()
    {
        var keyInput = Input.GetAxis("Horizontal");
        var newVelocity = rigid.velocity;
        newVelocity.x = keyInput * speedRun;
        rigid.velocity = newVelocity;
    }
    private void UpdateJump()
    {
        var keyInput = Input.GetAxis("Jump");
        var newVelocity = rigid.velocity;
        newVelocity.y = keyInput * jumpHight;
        Debug.Log(keyInput);
        if (keyInput == 1 && OnGround())
        {
            rigid.velocity = newVelocity;
        }  
    } 
    private void UpdateFacing()
    {
        var xAngle = rigid.velocity.x >= 0 ? 0 : 180;
        transform.rotation = Quaternion.Euler(0, xAngle, 0);
    }

    private bool OnGround()
    {
        return true;
    }
}
