using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {

    public float speed = 5;
    public Rigidbody rb;

    private void Start()
    {
      
}
    // Update is called once per frame
    void Update () {
        rb.velocity = (transform.forward * speed);

        Destroy(gameObject,2);


        
    }
}
