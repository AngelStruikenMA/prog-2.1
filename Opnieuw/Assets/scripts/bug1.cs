using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bug1 : MonoBehaviour
{

    public GameObject GameObject;
   

    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Playerrr")
        {
            Destroy(gameObject);
            
        }

    }
}
