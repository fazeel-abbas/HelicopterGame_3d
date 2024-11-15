using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public GameObject heli;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.8f); // move in z diresction
        transform.LookAt(heli.transform); // lookat means direction will be towards helicopter
    }
}
