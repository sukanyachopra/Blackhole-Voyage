﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class console_clue : MonoBehaviour
{

    
    [SerializeField]
    private GameObject clue1;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShowCursor();
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                HideCursor();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            HideCursor();
        }
    }


    public void ShowCursor()
    {

        clue1.SetActive(true);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void HideCursor()
    {

        clue1.SetActive(false);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
