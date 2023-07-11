using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colicion : MonoBehaviour


{
    float x;
    float y;
    float z;
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
        
        if (other.CompareTag("goma"))
        {

                Destroy(other.gameObject);
                x += -0.10f; //* Time.deltaTime;
                y += -0.10f; //* Time.deltaTime;
                z += -0.10f; //* Time.d
                transform.localScale += new Vector3(x, y, z);
        }
    }
}
