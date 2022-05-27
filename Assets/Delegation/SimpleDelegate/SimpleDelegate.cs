using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace delegates
{
    public delegate void Function(int value); //esto es un tipo de dato, no una variable.

    public class SimpleDelegate
    {

        Function deleg; //variable de tipo foo, que es un delegate.
                        // Start is called before the first frame update

        // Update is called once per frame

        public void Execute(int value) {
            deleg.Invoke(value);
        }


        public void AddFunction(Function function)
        {
            deleg += function;
        }

        public void RemoveFunction(Function function)
        {
            deleg -= function;
        }

    }
}