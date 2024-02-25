using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
	Transform transform;
	
    // Start is called before the first frame update
    void Start()
    {
        Transform transform = GetComponent<Transform>();;
		this.transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal"); 
        if (movement>0)	transform.position += new Vector3(0.01f, 0,0);
        if (movement<0)	  transform.position += new Vector3(-0.01f, 0,0);
    }
}