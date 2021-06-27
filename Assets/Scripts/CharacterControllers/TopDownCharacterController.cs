using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    public float speed = 1.0f;

    public AudioClip deathClip;

    Animator        animator;
    SpriteRenderer  spriteRenderer;
    new Rigidbody2D rigidbody2D;
    public bool     dead = false;

    public bool freeMovements = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        // player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        if (dead || freeMovements)
            return;

        var movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        rigidbody2D.MovePosition(rigidbody2D.position + movement * speed * Time.fixedDeltaTime);

        if (animator != null)
        {
            animator.SetFloat("MoveX", movement.x);
            animator.SetFloat("MoveY", movement.y);
        }

        if (movement.magnitude > 0)
            spriteRenderer.flipX = movement.x > 0;
    }

    public void Die()
    {
        rigidbody2D.isKinematic = true;
        dead = true;

        if (animator != null)
            animator.SetTrigger("Death");
        // AudioManager.PlayOnShot(deathClip);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (dead)
            return;
        
        // TODO: take hit SFX
    }
}
