using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animate;
    private BoxCollider2D collide;
    private SpriteRenderer sprite;

    private float xDir;

    private enum state { idle, running, jumping, falling }

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animate = GetComponent<Animator>();
        collide = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        xDir = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(xDir * 7f, rb.velocity.y);

        if (Input.GetButtonDown("Jump")) {
            rb.velocity = new Vector2(rb.velocity.x, 7f);
        }
        AnimationUpdate();
    }

    private void AnimationUpdate() {
        state currState;
        if (xDir < 0f) {
            currState = state.running;
            sprite.flipX = true;
        } else if (xDir > 0f) {
            currState = state.running;
            sprite.flipX = false;
        } else {
            currState = state.idle;
        }

        if (rb.velocity.y > .1f) {
            currState = state.jumping;
        } else if (rb.velocity.y < -.1f) {
            currState = state.falling;
        }

        animate.SetInteger("currState", (int)currState);
    }
}
