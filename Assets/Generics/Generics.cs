using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Generics<T>
{

    public T Data { get; set; }
    private T[] array;
    private int size;
    
    
    /// <summary>
    /// El constructor no lleva <T>
    /// </summary>
    /// <param name="Data"></param>
    public Generics(T Data)
    {
        this.Data = Data;
        array = new T[size];
        
    }

    public bool Contains(T value)
    {
        foreach (T temp in array)
        {
            if (!temp.Equals(value))
                continue;
            return true;
        }
        return false;
    }

    /// <summary>
    /// En este caso no usamos T, es decir, no es necesario crear una clase generica para tener métodos genéricos.
    /// </summary>
    /// <typeparam name="F"></typeparam>
    /// <param name="fTypeParamater"></param>
    public void OnlyGenericMethod<F,R>(F fTypeParamater, R rTypeParameter)
    {
        Debug.Log(fTypeParamater.GetType().Name);
    }

}
