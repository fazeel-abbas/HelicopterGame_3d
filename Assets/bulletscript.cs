using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        explosion.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 1);


    }


    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.StartsWith("enemy"))
        {
            Destroy(col.gameObject); //enemy is destroyed
            Instantiate(explosion, transform.position, transform.rotation);
            explosion.SetActive(true);
            print("There is collision");
        }


        Destroy(transform.gameObject);

    }

}
