using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliceCharacter : MainCharacter
{
    // Start is called before the first frame update
    protected override void Start()
    {
        moveSpeed = 8f;
        jumpUnits = 10f;
        base.Start();
    }
}
