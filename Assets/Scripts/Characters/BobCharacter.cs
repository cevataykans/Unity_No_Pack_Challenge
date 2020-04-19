using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobCharacter : MainCharacter
{
    // Start is called before the first frame update
    protected override void Start()
    {
        moveSpeed = 4f;
        jumpForce = 9f;
        power = new GroundBreaker();
        weapon = new GiantClub();
        base.Start();
    }
}
