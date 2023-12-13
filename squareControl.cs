using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squareControl : MonoBehaviour
{

    public GameObject square;
    public float speed = 0f;
	float frictionValue = 1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		 
		 float dt = Time.deltaTime;
		 float translationDelta = speed * dt;
		 speed = Mathf.Lerp(speed, 0f, frictionValue * Time.deltaTime);
		
	
       
    if (Input.GetKey(KeyCode.D)){
		transform.position -= Vector3.left * translationDelta;
	}
	if (Input.GetKey(KeyCode.A)){
		transform.position += Vector3.left * translationDelta;
	}
	if (Input.GetKey(KeyCode.W)){
		 transform.position +=  Vector3.up * translationDelta;
	}
	if (Input.GetKey(KeyCode.S)){
		 transform.position -= Vector3.up * translationDelta;
	}
    }
}
