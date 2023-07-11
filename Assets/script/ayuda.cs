using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ayuda : MonoBehaviour
{
    float x;
    float y;
    float z;
    Vector3 newSize;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
       private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("ayuda"))
        {

                Destroy(other.gameObject);
                x += 0.15f; //* Time.deltaTime;
                y += 0.15f; //* Time.deltaTime;
                z += 0.15f; //* Time.d
                transform.localScale += new Vector3(x, y, z);
        }
    }
}
