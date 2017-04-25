using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour {

    public static bool visible = false;

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().enabled = visible;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        visible = true;
        GetComponent<Renderer>().enabled = visible;
    }

    private void OnMouseExit()
    {
        visible = false;
        GetComponent<Renderer>().enabled = visible;
    }
}
