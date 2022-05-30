using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace delegates
{
    public class DelegateWithEvent
    {
        public static event Function OnCallFunction;

        public void Add(Function func)
        {
            OnCallFunction += func;
        }

        public void Remove(Function func)
        {
            OnCallFunction -= func;
        }

        

    }
}