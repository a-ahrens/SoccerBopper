using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Example : MonoBehaviour
{
    float ZSpeed = 10.0f;
    float XSpeed = 10.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        rb.drag = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector3(Input.GetAxis("Horizontal") * XSpeed, 0, Input.GetAxis("Vertical") * ZSpeed), ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Ball>())
        {
            if(!other.gameObject.GetComponent<ConstantForce>())
                other.gameObject.AddComponent<ConstantForce>();
            else
            {
                other.gameObject.GetComponent<ConstantForce>().force = rb.velocity * 1.5f;
            }
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.GetComponent<Ball>())
        {
            other.gameObject.GetComponent<ConstantForce>().force = Vector3.zero;
        }
    }
}
