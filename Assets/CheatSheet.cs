using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheatSheet : MonoBehaviour
{
    Toggle toggle;
    Image bg;
    GameObject[] cheatKeys = new GameObject[4];
    public bool cheatIsOpen = false;

    ScreenKeys screenKeys;

    private void Start()
    {
        bg = GetComponent<Image>();
        bg.enabled = false;

        for(int i = 0; i <= 3; i++)
        {
            cheatKeys[i] = transform.GetChild(i).gameObject;
            cheatKeys[i].SetActive(false);
        }

        toggle = GameObject.Find("Toggle").GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(delegate { OpenCheatSheet(toggle); });

        screenKeys = GameObject.Find("Canvas").transform.GetChild(2).GetComponentInChildren<ScreenKeys>();
    }

    public void OpenCheatSheet(Toggle toggle)
    {
        bool state = toggle.isOn;
        cheatIsOpen = state;

        print(state);

        bg.enabled = state;
        for (int i = 0; i <= 3; i++)
        {
            cheatKeys[i].SetActive(state);
        }

        //screenKeys = GameObject.Find("ScreenKeys").GetComponent<ScreenKeys>();
        if (screenKeys != null)
        {
            screenKeys.CheatResizeKeys(state);
        }
    }
}
