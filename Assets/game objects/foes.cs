using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foes : MonoBehaviour
{
    public float speed = 5.0f;
    private float zDestroy = -14.0f;
    private Rigidbody objectRb;


    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objectRb.AddForce(Vector3.forward * -speed);
        if(transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }


    }
}
