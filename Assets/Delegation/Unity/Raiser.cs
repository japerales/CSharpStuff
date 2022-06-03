using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //necesario para event handler...

//public delegate void SimpleFunction();

public class Raiser : MonoBehaviour
{
    //public static event SimpleFunction OnDead;
    public static event Action OnDead; //Action y Func son delegates ya preparados para usar de tipo generic
    // Start is called before the first frame update
    void Start()
    {
        OnDead();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
