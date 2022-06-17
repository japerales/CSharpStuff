using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class FuncsYActions : MonoBehaviour
{
    Func<int> ejemplo1;
    Func<string, int, Vector3> ejemplo2;

    Action<Vector3, GameObject> action1;
    Predicate<int> predicate1;
    // Start is called before the first frame update
    void Start()
    {
        ejemplo1 += method1;
        ejemplo2 += method2;
        action1 += method3;
        predicate1 += isEven;
        EjemploConCallback(2, "hola", ()=>2 * 3);

    }

    public int method1()
    {
        return 1;
    }

    public bool isEven(int value)
    {
        return value % 2 == 0;
    }

    public void method3(Vector3 v, GameObject go)
    { }

    public Vector3 method2(string st, int e)
    {
        return Vector3.zero;
    }

    public void EjemploConCallback(int i, string st, Func<int> OnReset)
    {
        //i = 2 + OnReset(3);
        st.Clone();

        
    }

    public void WorkflowRandom<T, U>(Action<T> method1, Func<T, U> method2, T variable)
    {
        //hago algo

        method1(variable);

        //hago otra cosa

        U var = method2(variable);
    }

}
