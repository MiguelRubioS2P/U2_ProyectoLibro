using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCreator : MonoBehaviour
{
    //Creamos una variable que añadiremos el prefab correspondiente para tratarlo en el script
    public GameObject bookPrefabRef;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si pulsamos la tecla b creamos una instancia de un GO
        if (Input.GetKeyUp(KeyCode.B))
        {
            //Si en un GO cuando lo instanciamos le ponemos una posición es obligatorio poner Quaternion que es la rotacion
            GameObject book = Instantiate(bookPrefabRef, transform.position, Quaternion.identity);
        
        }

    }

}
