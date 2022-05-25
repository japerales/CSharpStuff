using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IWeaponTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Sword swd = new Sword();
        IWeapon sword = new Sword();
        IWeapon whip = new Whip();

        Armory shop = new Armory();

        shop.weapons.Add(sword);
        shop.weapons.Add(whip);

        shop.TestWeapons();
    }
}
