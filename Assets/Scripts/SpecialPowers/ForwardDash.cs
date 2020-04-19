using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ForwardDash : SpecialPower
{
    public IEnumerator PerformSpecialPower(Rigidbody2D body)
    {
        float prevHorizontalSpeed = body.velocity.x;
        float prevGravityScale = body.gravityScale;

        body.gravityScale = 0;
        body.velocity = body.velocity.x >= 0 ? new Vector2(25f, 0f) : new Vector2(-25f, 0f);
        yield return new WaitForSeconds(0.1f);

        body.gravityScale = prevGravityScale;
        body.velocity = new Vector2(prevHorizontalSpeed, -5f);
    }
}
