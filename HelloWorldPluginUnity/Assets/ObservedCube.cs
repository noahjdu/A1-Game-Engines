using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObservedCube : MonoBehaviour {
    public  ObserverChange cube;
	// Use this for initialization
	void Start () {
		
	}
	public bool LocalChecker = false;
	// Update is called once per frame
	void FixedUpdate () {
        if (cube.checker == true)
        { ObserveChange(); }


	}
    void ObserveChange()
    {
        if (cube.membersThrough <= cube.members)
        {
            if (cube.color == true)
            {
                gameObject.transform.position = gameObject.transform.localPosition + new Vector3(0, 0, 6);
                // gameObject.GetComponent<Material>().color.Equals("Blue");
            }
            else if (cube.color == false)
            {
                gameObject.transform.position = gameObject.transform.localPosition + new Vector3(0, 0, -6);
                // gameObject.GetComponent<Material>().color.Equals("Red");
            }
            cube.membersThrough++;
            Debug.Log(cube.membersThrough);
        }
        else { cube.checker = false;
            cube.membersThrough = 0;
        }
    }

}
