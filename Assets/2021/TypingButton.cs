using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;               //Using 'UnityEngine.UI' !!

public class TypingButton : MonoBehaviour
{
    public bool buttonSelected = false;
    bool changeColor = false;

    void Update()
    {
        if(buttonSelected)
        {
            gameObject.GetComponent<Image>().color = Color.green;
        }
        else
        {
            gameObject.GetComponent<Image>().color = Color.white;
        }

        buttonSelected = false;
    }
}
