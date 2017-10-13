using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpNTimesHandler : IJumpHandler {

    private int jumpCounter;
    private int maxNumberOfJumps;

    public JumpNTimesHandler(int n = 1)
    {
        maxNumberOfJumps = n;
        ResetState();
    }

    public static IJumpHandler SingleJumpHandler()
    {
        return new JumpNTimesHandler(1);
    }

    public static IJumpHandler DoubleJump()
    {
        return new JumpNTimesHandler(2);
    }

    public bool CanJump()
    {
        return jumpCounter > 0;
    }

    public void Jump()
    {
        jumpCounter--;
    }

    public void ResetState()
    {
        jumpCounter = maxNumberOfJumps;
    }
}
