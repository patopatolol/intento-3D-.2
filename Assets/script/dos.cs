using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dos : MonoBehaviour
{
    public GameObject cubeGameobject;

    public Material myMaterial;

    public Color myColor;
     

     //[Range(0f,1f)]
    //public float myAlfha= 1f;
    void Start()
    {
     myMaterial = cubeGameobject.GetComponent<MeshRenderer>().material;

            myColor = Color.white;
            myColor.a = 1f;

             
    }

    // Update is called once per frame
    void Update()
    {
               myMaterial.color = myColor;

          //  myColor.a = myAlfha;
    }
     private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("goma") )//si toca el tag goma a my color se le van a quitar 0.50 de f 
        {
          if (myColor.a <= 0.1f)
            {
                Destroy(other.gameObject);
            }
            else
            {
                myColor.a = 0.1f;
            }

        
        }
  
       
    }
}

