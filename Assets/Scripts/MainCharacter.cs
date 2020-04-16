using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    public float moveSpeed;
    public float jumpUnits;

    private Color color;
    private Rigidbody2D body;

    private bool onAir;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        color = GetComponent<SpriteRenderer>().color;
        body = GetComponent<Rigidbody2D>();
        onAir = false;
    }

    public void MoveCharacter( float velocityX)
    {
        body.velocity = new Vector2( velocityX * moveSpeed, body.velocity.y);
    }

    public void Jump()
    {
        if ( !onAir)
        {
            body.AddForce(Vector2.up * jumpUnits, ForceMode2D.Impulse);
            onAir = true;
        }
    }

    public bool isJumping()
    {
        return onAir;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if ( collision.gameObject.tag != "Wall")
        {
            onAir = false;
        }
    }
}
