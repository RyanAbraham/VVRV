using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

    public float upSpeed = 50;
    public float sideSpeed = 35;
    public float orbitSpeed = 0.0005f;
    private GameObject camera;

    // Use this for initialization
    void Start () {
        camera = GameObject.FindGameObjectsWithTag("MainCamera")[0];
    }
	
	// Update is called once per frame
	void Update () {
        //transform.RotateAround(camera.transform.position, Vector3.forward, orbitSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, upSpeed * Time.deltaTime);
        transform.Rotate(Vector3.left, sideSpeed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
}
