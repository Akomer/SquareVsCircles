using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class PlayerKeyboardInput : MonoBehaviour {

    private PlayerController playerController;

	// Use this for initialization
	void Start () {
        playerController = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            playerController.Shoot();
        }

        var horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0)
        {
            playerController.SideForce(horizontalInput);
        }

        if (Input.GetButtonDown("Jump"))
        {
            playerController.Jump();
        }
	}
}
