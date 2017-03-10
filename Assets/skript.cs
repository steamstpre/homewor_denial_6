using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Update is called once per frame

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            Vector3 position = this.transform.position;
            position.x++;
            transform.position = position;
        }

        if (Input.GetKey(KeyCode.V))
        {
            Vector3 position = transform.position;
            position.x--;
            transform.position = position;
        }
        if (Input.GetKey(KeyCode.U))
        {
            Vector3 position = transform.position;
            position.z++;
            transform.position = position;
        }
        if (Input.GetKey(KeyCode.P))
        {
            Vector3 position = transform.position;
            position.z--;
            transform.position = position;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 position = transform.position;
            position.y++;
            transform.position = position;

        }
    }
}

