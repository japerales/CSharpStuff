using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace delegates
{
    public delegate void Function(int value); //esto es un tipo de dato, no una variable.
    public delegate void FunctionGeneric<T>(T value); 
    //un delegate también puede ser firma de una función como parámetro

    public class SimpleDelegate
    {

        public Function deleg; //variable de tipo function, que es un delegate.
                               // Start is called before the first frame update
        public event Function OnFunction; //los event son un wrapper simple y directo que no permite inyectarle null.
        // Update is called once per frame

        public void RaiseEvent(int value)
        {
            deleg(2);
        }

        /// <summary>
        /// Al hacer publico el delegate esto es innecesario...
        /// </summary>
        /// <param name="function"></param>
        public void AddFunction(Function function)
        {
            deleg += function;
        }

        public void RemoveFunction(Function function)
        {
            deleg -= function;
        }

    }

    public class DelegateGeneric
    {
        //podemos crear eventos basados en delegados generic
        //OJO! al ser static solo puede haber uno evento por clase, no por instancia!
        public static event FunctionGeneric<Vector3> OnFunctionGenericVector;
        public static event FunctionGeneric<float> OnFunctionGenericFloat;

        //Podemos usar los eventos como formas de notificar al resto de objetos de algo:
        public static void RaiseGenericVector()
        {
            //Hacemos algo
            OnFunctionGenericVector(Vector3.zero); //funciona como un delegado
        }
    }

}