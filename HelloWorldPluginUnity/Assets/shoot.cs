using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
    public bool canshoot = true; 
	// Use this for initialization
	void Start () {
		
	}
   public GameObject bullet;
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("f") == true)
        {
            if (canshoot == true)
            {
                canshoot = false;
                Instantiate(bullet, transform.position, transform.rotation);
                
                StartCoroutine(Example());
            }
        }
	}

    IEnumerator Example()
    {

        yield return new WaitForSeconds(.5f);
        canshoot = true;
        //jumpnoise.SetActive(false);

    }




}
