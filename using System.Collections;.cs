using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float m_speed = 5f;
    Rigidbody rb;

    public Transform playerCam;
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();

        
        playerCam.transform.position = transform.position;

        //poprawić!!!!
        transform.rotation = playerCam.transform.rotation;

    }

    void Movement()
    {
         Vector3 m_Input= new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        rb.MovePosition(transform.position + m_Input * Time.deltaTime * m_speed);
    }

}
