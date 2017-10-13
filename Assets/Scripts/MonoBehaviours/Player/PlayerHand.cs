using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour {

    public Weapon weapon;

    public void UseWeapon()
    {
        if (weapon != null)
        {
            weapon.Fire();
        }
    }
}
