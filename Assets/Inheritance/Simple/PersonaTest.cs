using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonaTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Persona Carlos = new Persona("Carlos", 28);
        Persona Maria = new Persona("Maria", 20);
        Carlos.AnadirAmigo(Maria);
        Trabajador Jeronimo = new Trabajador("Jeronimo", 21, "Programador");
        //Jeronimo.Andar();
        Carlos.AnadirAmigo(Jeronimo);

        foreach (Persona amigo in Carlos.Amigos)
        {
            Debug.Log(amigo);
            if (amigo is Trabajador)
            {
                (amigo as Trabajador).Currar();
            }
        }
    }

}
