using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona
{
    public string Nombre { get; }
    public int Edad { get; set; }
    public List<Persona> Amigos;

    public Persona(string _Nombre, int _Edad)
    {
        Amigos = new List<Persona>();
        Nombre = _Nombre;
        Edad = _Edad;
    }

    public virtual void Andar()
    {
        Debug.Log("Estoy paseando, pero solito :(");
    }

    public void Andar(Persona coleguito)
    {
        Debug.Log("Estoy paseando con " + coleguito);
    }

    public override string ToString()
    {
        return Nombre;
    }

    public void AnadirAmigo(Persona amigo)
    {
        if (!Amigos.Contains(amigo))
            Amigos.Add(amigo);
    }

    public void QuitarAmigo(Persona amigo)
    {
        if (Amigos.Contains(amigo))
            Amigos.Remove(amigo);
    }
}

class Trabajador : Persona
{
    public string Empleo { get; set; }

    public Trabajador(string currante, int edad, string _Empleo) : base(currante, edad)
    {
        this.Empleo = _Empleo;
    }

    public override string ToString()
    {
        return base.ToString() + " que trabaja como " + Empleo;
    }

    public override void Andar()
    {
        Debug.Log("Estoy paseando hacia el trabajo");
    }

    public void Currar()
    {
        Debug.Log("Estoy currando, macho.");
    }
}
