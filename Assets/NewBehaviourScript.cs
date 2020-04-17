using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float target_rotate = 100;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var target = Quaternion.Euler(new Vector3(target_rotate, 0, 0));

        var now_rot = transform.rotation;

        if (Quaternion.Angle(now_rot, target) <= 1)
        {
            transform.rotation = target;
        }
        else
        {
            transform.Rotate(new Vector3(0.0f, 0.2f, 0.5f));
        }

    }
}
