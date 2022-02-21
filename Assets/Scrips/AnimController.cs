using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public Animator anim;

    
    public void Die()
    {
        anim.SetBool("die", true);
    }
    public void Hurt()
    {
        anim.SetBool("hurt", true);
        Invoke(nameof(Idle), 0.5f);
    }
    private void Idle()
    {
        anim.SetBool("hurt", false);
    }
    public void Attack()
    {
        anim.SetBool("attack", true);
    }
}
