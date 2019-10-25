using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookHitsFloor : MonoBehaviour
{
    public GameObject bookPrefabReference;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "book_0001a" || collision.gameObject.name == "book_0001a(Clone)")
        {

            //Destroy(collision.gameObject);


            GameObject book = Instantiate(bookPrefabReference);

            //float xOffset = Random.Range(-1.0f, 1.0f);
            //book.transform.Translate(new Vector3(xOffset, 0, 0));
            float yRotOffset = Random.Range(-90.0f, 90.0f);
            book.transform.Rotate(new Vector3(0, yRotOffset, 0));

        }

    }
    
    
}
