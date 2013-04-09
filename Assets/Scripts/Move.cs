using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    public float MoveSpeed = 4.0f;
    public float RotateSpeed = 50.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * MoveSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {            
            transform.Rotate(Vector3.up, Time.deltaTime * -RotateSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * RotateSpeed);
        }
	}
}
