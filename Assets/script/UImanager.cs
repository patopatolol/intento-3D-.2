using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    public GameObject pauseMenu;
    public Animator menuAnim;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           if (Input.GetKey(KeyCode.Q))
        {
            menuAnim.SetBool("2.2", true);

        }
        else
        {

            //Bloqueamos el cursor
            menuAnim.SetBool("2.2", false);

        }
        
         


    }
}
