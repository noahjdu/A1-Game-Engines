using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverChange : MonoBehaviour {



    public bool color = true;
    public bool checker = false;
    public int members = 3;
    public int membersThrough = 0;

    // Use this for initialization


    // Update is called once per frame
    void Update () {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            checker = true;
            
            Debug.Log("I Got Hit!");
            if (color == true)
            { color = false;
                //gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0, 6);
                gameObject.transform.Translate(0, 0, 5); 

                gameObject.GetComponent<Material>().color.Equals("Blue");
            }
            else
            { color = true;
                gameObject.transform.Translate(0, 0, -5); //= gameObject.transform.position + new Vector3(0, 0, -6);
                gameObject.GetComponent<Material>().color.Equals("Red");

            }
          
        }
        

    }
}
