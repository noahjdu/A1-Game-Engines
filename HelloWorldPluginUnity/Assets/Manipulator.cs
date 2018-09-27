using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulator : MonoBehaviour {
    public Movement MS;
	
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("p"))
        {
            commandtoMirror();
        }
	}
    void commandtoMirror()
    {
        Debug.Log("You are now using inverted controls MWAHAHAHA");
        MS.mirrorcontrols();

    }


}
