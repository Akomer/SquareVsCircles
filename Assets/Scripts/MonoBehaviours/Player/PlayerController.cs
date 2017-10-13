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
    

    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        player.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    public void SideForce(float input)
    {
        player.AddForce(Vector2.right * moveForce * input, ForceMode2D.Force);
    }

    public void Shoot()
    {
        hand.UseWeapon();
    }
}
