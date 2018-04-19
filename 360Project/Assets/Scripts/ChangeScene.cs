using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public string scene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoToScene()
    {
        Debug.Log("Going inside");
        SceneManager.LoadScene(scene);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter triggered");
        SceneManager.LoadScene(scene);
    }


}
