using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Mover : MonoBehaviour
{

    //[SerializeField] private float MoveSpeed = 5.0f;
    //[SerializeField] private float KickForce = 1f;

    //[SerializeField] private float FlipSpeed = 4f;
    //private bool isFlipping = false;

    //private Rigidbody rb;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    CheckMovement();
    //    CheckForKick();
    //}

    //private void CheckMovement()
    //{
    //    float xValue = 0;
    //    float zValue = 0;

    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        xValue = 1 * Time.deltaTime * MoveSpeed;
    //    }
    //    else if(Input.GetKey(KeyCode.A))
    //    {
    //        xValue = -1 * Time.deltaTime * MoveSpeed;
    //    }

    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        zValue = 1 * Time.deltaTime * MoveSpeed;
    //    }
    //    else if (Input.GetKey(KeyCode.S))
    //    {
    //        zValue = -1 * Time.deltaTime * MoveSpeed;
    //    }

    //    transform.Translate(xValue, 0, zValue);
    //}
    
    //private void CheckForKick()
    //{

    //    if (Input.GetKeyDown(KeyCode.Space) && !isFlipping)
    //    {
    //        isFlipping = true;
    //        StartCoroutine(RotateOverTime(FlipSpeed));
    //    }

    //}

    //IEnumerator RotateOverTime(float rotateSpeed)
    //{
    //    yield return null;
    //}

    //private void Kick()
    //{
    //        transform.Rotate(0, 0, FlipSpeed);
    //}


}
