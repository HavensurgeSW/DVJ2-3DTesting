using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//El Typedef mas rancio de C#
using Random = UnityEngine.Random;

//Metadata, atributos. Se ponen fuera de la funcion / clase.
[RequireComponent(typeof(MeshRenderer))]
public class Testing : MonoBehaviour
{

    private MeshRenderer tuki;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent es una operacion cara. NO LA USES EN UPDATE. Hacete una variable extra y guarda la info en Start
        tuki = GetComponent<MeshRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //Random es una clase estatica, no tenes que instanciarla.
        Random.Range(1,10);
    }
}
