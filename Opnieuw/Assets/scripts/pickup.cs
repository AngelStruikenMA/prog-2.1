using System;
using System.Collections;
using UnityEngine;

public class pickup : MonoBehaviour
{  

    public GameObject GameObject;
   public static event Action BallDead;

    void Start()
    {
    
    } 
  
   
    // Update is called once per frame
    void Update()
    {
    }
     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            BallDead?.Invoke();
        }
        
    }
}
