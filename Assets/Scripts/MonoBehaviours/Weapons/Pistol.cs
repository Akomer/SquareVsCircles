using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public Bullet bulletPrefab;

    private float fireDelay = 0.4f;
    private float timeStampForFire;

    override public void Fire()
    {
        if (ReadyToFire())
        {
            FireWeapon();
        }
    }

    private void FireWeapon()
    {
        timeStampForFire = Time.time + fireDelay;
        var bulletInstance = Instantiate<Bullet>(bulletPrefab);
        bulletInstance.transform.localPosition = transform.position;
        bulletInstance.ShootOut(transform.forward);
    }

    private bool ReadyToFire()
    {
        return Time.time >= timeStampForFire;
    }
}
