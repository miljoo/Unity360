using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraRay : MonoBehaviour {

    public Image counter;
    public float maxDuration;
    public float duration;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        

        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        RaycastHit hit;
        if(Physics.Raycast (transform.position, fwd, out hit, 30))
        {
            if (duration < maxDuration)
            {
                duration += Time.deltaTime;
            }
   
            counter.enabled = true;
            counter.transform.position = Camera.main.WorldToScreenPoint(hit.collider.transform.position);
            counter.fillAmount = Mathf.Lerp(0, 1, duration / maxDuration);

            if(counter.fillAmount >= 1)
            {
                hit.collider.GetComponent<ChangeScene>().GoToScene();
            }


        }
        else
        {
            duration = 0;
            counter.enabled = false;
        }

        Debug.DrawRay(transform.position, fwd * 10, Color.red, 2);

	}
}
