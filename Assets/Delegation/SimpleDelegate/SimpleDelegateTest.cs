using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace delegates
{
    public class SimpleDelegateTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //deleg y las dos funciones de other class no se conocen: el código está desacoplado.
            SimpleDelegate dlg = new SimpleDelegate();
            OtherClass other = new OtherClass();
            OtherClass2 other2 = new OtherClass2();
            dlg.deleg += other.AnyMatchingFunction;
            dlg.deleg += other2.AnyMatchingFunction2;
            //dlg.deleg = null; //vacía el delegate!
            dlg.deleg.Invoke(2); //deleg da una serie de funcionalidades y poderes...
            
            
            
            dlg.OnFunction+= new OtherClass().AnyMatchingFunction;
            
            //dlg.OnFunction = null; <-- no está permitido.
            /*dlg.AddFunction(new OtherClass().AnyMatchingFunction);
            dlg.AddFunction(new OtherClass().AnyMatchingFunction);
            dlg.AddFunction(new OtherClass2().AnyMatchingFunction2);*/
            dlg.RaiseEvent(2);
            DelegateGeneric.OnFunctionGenericVector += other2.Vector3Func;
            DelegateGeneric.RaiseGenericVector();
            other2.FunctWithParamDeleg(ExampleWithInt);
            
        }


        public void ExampleWithInt(int value)
        {
            Debug.Log("Escribo un" + value);
        }
    }
}