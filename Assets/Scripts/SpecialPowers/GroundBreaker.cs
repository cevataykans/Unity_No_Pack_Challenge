using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GroundBreaker : SpecialPower
{
    public IEnumerator PerformSpecialPower( Rigidbody2D body)
    {
        body.velocity = new Vector2(0, -15);

        yield return null;
    }
}
