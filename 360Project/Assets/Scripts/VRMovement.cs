using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMovement : MonoBehaviour {
    public float speed;
    public GameObject footsteps;
    public GameObject container;
    public GameObject footstepsRotator;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
        {
            if (hit.transform.gameObject.name == "Footsteps")
            {
                footsteps.GetComponent<Renderer>().material.color = Color.cyan;
                container.transform.Translate(footstepsRotator.transform.forward * speed * Time.deltaTime);
            }
            else
            {
                footsteps.GetComponent<Renderer>().material.color = Color.blue;
            }

        }
    }
}
