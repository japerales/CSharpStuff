using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace delegates
{
    public class OtherClass
    {

        public void AnyMatchingFunction(int val)
        {
            Debug.Log("One function showing " + val);
        }
    }
    public class OtherClass2
    {

        public void AnyMatchingFunction2(int val)
        {
            Debug.Log("Another function showing " + val);
        }

        public void Vector3Func(Vector3 v) {
            Debug.Log(v);
        }

        //esta función recibe un delegado como parámetro. Es potente para implementar patrones como el strategy.
        public void FunctWithParamDeleg(Function func) //aqui se le puede inyectar cualquier función
        {
            //hago cosas
            func(3);

            //hago otras cosas
        }
    }


}