using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D player;
    public PlayerHand hand;
    private float jumpForce = 5;
    private float moveForce = 8;

    private bool inTheAir;
    private IJumpHandler jumpHandler;

    private void Awake()
    {
        player = GetComponent<Rigidbody2D>();
        jumpHandler = JumpNTimesHandler.DoubleJump();
    }

    public void JumpCommand()
    {
        if (jumpHandler.CanJump())
        {
            Jump();
        }
    }

    public void SideForce(float input)
    {
        player.AddForce(Vector2.right * moveForce * input, ForceMode2D.Force);
        UpdatePlayerForwardDirection();
    }

    public void Shoot()
    {
        hand.UseWeapon();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpHandler.ResetState();
    }

    private void UpdatePlayerForwardDirection()
    {
        transform.localRotation = player.velocity.x < 0 ? Quaternion.Euler(0f, 180f, 0f) : Quaternion.identity;
    }

    private void Jump()
    {
        jumpHandler.Jump();
        player.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
