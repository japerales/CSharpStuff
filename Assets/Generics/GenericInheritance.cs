using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericInheritance<T> where T:Collider
{
        
}

//Delegate generico con parámetro T y constraint, donde T debe ser un struct.
public delegate void GenericMethod<T>(T arg) where T : struct;





