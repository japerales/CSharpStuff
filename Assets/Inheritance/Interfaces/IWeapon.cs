using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon
{
    void Attack();
}

public interface IMaterial : IWeapon
{
    void Example();
}

public class Sword : IWeapon
{
    public void Attack()
    {
        Debug.Log("La espada ataca con un corte horizontal");
    }

    public void Repair()
    {
        Debug.Log("Reparamos la espada yendo a un herrero");
    }
}

public class Whip : IWeapon
{
    public void Attack()
    {
        Debug.Log("El latigo baila hacia el enemigo en una rápida batida");
    }
}

public class Armory
{
    public List<IWeapon> weapons { get; set; }

    public Armory()
    {
        weapons = new List<IWeapon>();
    }

    public void TestWeapons()
    {
        foreach (var weapon in weapons)
        {

            if (weapon is Sword)
                (weapon as Sword).Repair();
            weapon.Attack();
        }
    }
}