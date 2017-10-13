using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBullet : Bullet {

    private void Awake()
    {
        speed = 15f;
        lifeTime = 1.5f;
    }
}
