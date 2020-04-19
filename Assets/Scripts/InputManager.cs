using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class InputManager : MonoBehaviour
{
    private MainCharacter mainCharacter;
    private bool canPerformability;

    public Canvas mobileControls;

    // Start is called before the first frame update
    void Awake()
    {
        mainCharacter = FindObjectOfType<MainCharacter>();

#if UNITY_ANDROID || UNITY_IOS

        mobileControls.gameObject.SetActive(true);
        //Instantiate(mobileControls);
#endif
    }

    private void FixedUpdate()
    {
        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        mainCharacter.MoveCharacter(x);

        if ( !mainCharacter.isJumping() && CrossPlatformInputManager.GetAxisRaw("Jump") == 1 )
        {
            mainCharacter.Jump();
            canPerformability = false;
        }
        else if (mainCharacter.isJumping() && CrossPlatformInputManager.GetAxisRaw("Jump") == 0)
        {
            canPerformability = true;
        }
        else if (mainCharacter.isJumping() && CrossPlatformInputManager.GetAxisRaw("Jump") == 1 && canPerformability)
        {
            mainCharacter.PerformSpecialMove();
            canPerformability = false;
        }
    }
}
