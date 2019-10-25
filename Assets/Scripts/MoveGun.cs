using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGun : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetAxis va de -1 a 1, para detectar los movimientos
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        Debug.Log(hInput);
        Debug.Log(vInput);
        //Time.deltaTime tiempo que tarda un frame en ejecutarse

        //estamos haciendo que se cambie el valor del componente transform con la funcion traslado
        //transform.Translate(new Vector3(hInput, 0, 0) * Time.deltaTime * moveSpeed);
        //transform.Translate(new Vector3(vInput, 0, 0) * Time.deltaTime * moveSpeed);

        //transform.Rotate(new Vector3(0, -hInput, 0) * Time.deltaTime * moveSpeed);
        

    }
}
