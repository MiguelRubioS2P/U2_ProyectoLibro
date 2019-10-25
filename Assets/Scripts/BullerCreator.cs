using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullerCreator : MonoBehaviour
{
    //Lo ponemos public para poder después desde los componentes añadirle el Prefab que deseamos
    public GameObject projectilPrefabRef;
    float thrust = 5.0f;
    float moveSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            GameObject projectil = Instantiate(projectilPrefabRef, transform.position, Quaternion.identity);

            projectil.GetComponent<Rigidbody>().AddForce(transform.forward * thrust, ForceMode.Impulse);

            Destroy(projectil, 5.0f);

        }

        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        Debug.Log(hInput);
        Debug.Log(vInput);
        //Time.deltaTime tiempo que tarda un frame en ejecutarse

        //estamos haciendo que se cambie el valor del componente transform con la funcion traslado
        //transform.Translate(new Vector3(-hInput, 0, vInput) * Time.deltaTime * moveSpeed);

    }

}
