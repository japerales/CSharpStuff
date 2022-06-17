using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PipelineBase
{

    public void Initialize()
    {
        Debug.Log("Inicializo");
    }

    public void Process()
    {
        Debug.Log("Processing");
    }

    public abstract void ForcedToImplement1();

    public virtual void AfterProcessMethod() { }

    public void LoopPipeline()
    {
        Initialize(); //metodo implementado que va a funcionar. Básico en el pipeline
        ForcedToImplement1(); //es necesario que se implemente en la clase hija.
        Process();//metodo implementado que va a funcionar. Básico en el pipeline
        AfterProcessMethod(); //opcional
    }

    


}
