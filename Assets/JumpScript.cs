using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour {

    public GameObject cube;
    public Vector3 jumpforce;
	// Use this for initialization
	void Start () {
        jumpforce = new Vector3(0f, 400f, 0f);
	}
    private void OnTriggerEnter()
    {
        print("Collide");
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            cube.GetComponent<Rigidbody>().AddForce(jumpforce);
        }
	}
}
