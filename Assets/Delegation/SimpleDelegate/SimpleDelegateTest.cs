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
            SimpleDelegate dlg = new SimpleDelegate();
            dlg.AddFunction(new OtherClass().AnyMatchingFunction);
            dlg.AddFunction(new OtherClass().AnyMatchingFunction);
            dlg.AddFunction(new OtherClass2().AnyMatchingFunction2);
            dlg.Execute(2);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}