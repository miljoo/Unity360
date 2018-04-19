using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.Euler(0, Camera.main.transform.localEulerAngles.y, 0);
    }
}
