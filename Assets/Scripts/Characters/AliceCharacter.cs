using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliceCharacter : MainCharacter
{
    // Start is called before the first frame update
    protected override void Start()
    {
        moveSpeed = 8f;
        jumpForce = 10f;
        power = new ForwardDash();
        weapon = new Gun();
        base.Start();
    }

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        body.gravityScale = 4f;
        base.OnCollisionEnter2D(collision);
    }
}
