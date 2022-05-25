using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharpCollections
{
    public class Example : MonoBehaviour
    {
        List<Vector3> vList; //lista de tipo concreto
        ArrayList vObjectList; //lista de objects, necesitará casting <-- poco recomendado
        Dictionary<int, List<Vector3>> routes; //OJO, ITERAR DICCIONARIOS ES LENTISIMO, USAMOS UNA LISTA PARALELA CON KEYS
        List<int> KeyRoutes;
        Dictionary<string, GameObject> Simple;
        // Start is called before the first frame update
        void Start()
        {
            vList = new List<Vector3>();
            routes = new Dictionary<int, List<Vector3>>();

            routes.Add(0, vList);

            Add(Vector3.up, Vector3.down, new Vector3(1, 4, 1), Vector3.forward);
            Add(Vector3.back, Vector3.left);
            PrintList();

        }

        /// <summary>
        /// tipo especial de vector que permite crear el array en la función invocadora
        /// </summary>
        /// <param name="points">solo acepta arrays unidimensionales</param>
        public void Add(params Vector3[] points)
        {

            foreach (Vector3 point in points)
            {

                vList.Add(point);
            }
        }

        void PrintList()
        {
            foreach (Vector3 v in vList)
                Debug.Log(v);
        }


        
    }
}