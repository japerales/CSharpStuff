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
    }

}