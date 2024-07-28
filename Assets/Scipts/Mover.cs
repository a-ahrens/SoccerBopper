using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] private float MoveSpeed = 5.0f;
    [SerializeField] private float JumpHeight = 5.0f;
    [SerializeField] private float KickForce = 1f;

    [SerializeField] private float FlipSpeed = 45f;
    private bool isFlipping = false;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
        CheckForKick();
    }

    private void CheckMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;

        transform.Translate(xValue, 0, zValue);
    }
    
    private void CheckForKick()
    {

        if (Input.GetKeyDown(KeyCode.Space) && !isFlipping)
        {
            isFlipping = true;
            StartCoroutine(RotateOverTime(FlipSpeed));
        }

        //if (Input.GetKeyDown(KeyCode.Space) && !isFlipping)
        //{
        //    isFlipping = true;
        //    Kick();
        //}
        //else if (isFlipping)
        //{
        //    Kick();
        //}

            //if(transform.rotation.z == 360f)
            //{
            //    isFlipping = false;
            //}
    }

    IEnumerator RotateOverTime(float rotateSpeed)
    {
        float angle = 360f / rotateSpeed / Time.deltaTime;
        float rotation = 0f;

        while (rotation < 360 && isFlipping)
        {
            rotation += angle;
            transform.Rotate(0,0,angle);
        }

        isFlipping = false;
        yield return null;
    }

    private void Kick()
    {
            transform.Rotate(0, 0, FlipSpeed);
    }


}
