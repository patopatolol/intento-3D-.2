using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float jumpforce;
    public float playerSpeed;
    Rigidbody Rb;

   

    void Start()  
    {
        Rb = GetComponent<Rigidbody>();

    }
    void Update()
    {
         float h = Input.GetAxis("Horizontal")* playerSpeed * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        Vector3 vector = new Vector3(h, 05f, v);
        transform.Translate(h, 0, v);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }
    }
}