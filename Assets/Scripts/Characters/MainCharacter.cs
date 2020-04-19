using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MainCharacter : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    protected Coroutine specialMove;
    protected Rigidbody2D body;

    protected SpecialPower power;
    protected WeaponBehavior weapon;

    private bool onAir;
    private bool performingSpecial;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        body = GetComponent<Rigidbody2D>();
        onAir = false;
        performingSpecial = false;
    }

    public void MoveCharacter( float velocityX)
    {
        if ( !performingSpecial)
        {
            body.velocity = new Vector2(velocityX * moveSpeed, body.velocity.y);
        }
    }

    public void Jump()
    {
        if ( !onAir && !performingSpecial)
        {
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            onAir = true;
        }
    }

    public bool isJumping()
    {
        return onAir;
    }

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if ( performingSpecial)
        {
            performingSpecial = false;
            StopCoroutine(specialMove);
        }
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Wall")
        {
            performingSpecial = false;
            onAir = false;
        }
    }

    public void PerformSpecialMove()
    {
        if ( !performingSpecial)
        {
            performingSpecial = true;
            specialMove = StartCoroutine(power.PerformSpecialPower(body));
        }
    }

    public void Attack()
    {
        weapon.Attack();
    }
}
