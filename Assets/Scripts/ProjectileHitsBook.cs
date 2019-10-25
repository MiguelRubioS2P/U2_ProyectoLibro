using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileHitsBook : MonoBehaviour
{
    public GameObject bookPrefabReference;
    

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "book_0001a" || collision.gameObject.name == "book_0001a(Clone)")
        {

            Destroy(collision.gameObject, 2.0f);


            //Instantiate(bookPrefabReference, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            //GameObject book = Instantiate(bookPrefabReference);
        }

    }

}
