using UnityEngine;

public interface IJumpHandler
{
    bool CanJump();
    void Jump();
    void ResetState();
}
