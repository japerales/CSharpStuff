using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LambdaExamples : MonoBehaviour
{
    //generic delegates + función anónima (expresión lambda)
    
    //los Func devuelven un tipo de dato
    Func<int, int> square = i => i * i;
    Func<int,int,bool> testForEquality = (n1,n2) => n1==n2;
    Func<Vector3, Vector3, float, Vector3> GetPointFromLine = (Point, Dir, distance) => Point + Dir.normalized*distance;
    //Los action no devuelven nada
    Action<string> sayHi = (name) => Debug.Log("Hi there, how are you " + name + "?");
    //Los predicate hacen un check de una condición, devolviendo un boolean
    Predicate<int> checkAdult = (age) => age > 18;
    Func<Vector3, Vector3> Normalize;
    private void Start()
    {
        Normalize = NormalizeVector;
        Debug.Log(square(2));
        Debug.Log(GetPointFromLine(Vector3.zero, Vector3.one, 3));

        if (checkAdult(34))
        { 
        }
    }

    //no hace falta que una expresión lambda esté sujeta a una linea
    public Vector3 NormalizeVector(Vector3 vec)
    {
        Vector3 normalized = vec / vec.magnitude;
        return normalized;
    }

}
