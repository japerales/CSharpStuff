using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subscrber : MonoBehaviour
{
    /// <summary>
    /// Ejemplo clásico para registrarse y deregistrarse
    /// </summary>
    private void OnEnable()
    {
        Raiser.OnDead += EnemyReset;
    }

    private void OnDisable()
    {
        Raiser.OnDead -= EnemyReset;
    }

    private void EnemyReset()
    {
        Debug.Log("Resetting enemy position");
    }
}
