using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tower2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    
        float randommizer = Random.Range(0.5f,2f);
        transform.localScale = new Vector3(randommizer,randommizer,randommizer);
    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
