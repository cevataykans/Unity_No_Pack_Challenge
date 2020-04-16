using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private MainCharacter mainCharacter;

    // Start is called before the first frame update
    void Awake()
    {
        mainCharacter = FindObjectOfType<MainCharacter>();
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        if (Input.GetAxis("Jump") > 0 && !mainCharacter.isJumping() )
        {
            mainCharacter.Jump();
        }
        mainCharacter.MoveCharacter(x);
    }
}
