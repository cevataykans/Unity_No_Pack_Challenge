using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobCharacter : MainCharacter
{
    protected override void Start()
    {
        moveSpeed = 4f;
        jumpUnits = 7f;
        base.Start();
    }
}
