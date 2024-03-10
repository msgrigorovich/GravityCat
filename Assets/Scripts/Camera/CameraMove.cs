using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
	Transform CameraTransform;
	
    // Start is called before the first frame update
    void Start()
    {
        Transform CameraTransform = GetComponent<Transform>();;
		this.CameraTransform = CameraTransform;
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal"); 
        if (movement>0)	CameraTransform.position += new Vector3(0.01f, 0,0);
        if (movement<0)	  CameraTransform.position += new Vector3(-0.01f, 0,0);
    }
}