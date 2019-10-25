using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCreator : MonoBehaviour
{
    public GameObject bookPrefabRef;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.B))
        {

            GameObject book = Instantiate(bookPrefabRef, transform.position, Quaternion.identity);
        
        }

    }

}
