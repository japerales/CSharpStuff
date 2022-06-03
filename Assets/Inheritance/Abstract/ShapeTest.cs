using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShapeCalculus(new Rectangle(2,3));
        ShapeCalculus(new Triangle(4));
    }

    public void ShapeCalculus(Shape sp)
    {
        Debug.Log(sp.GetArea());
        Debug.Log(sp.GetPerimeter());
    }

   
}
