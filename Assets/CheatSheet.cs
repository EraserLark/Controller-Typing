﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheatSheet : MonoBehaviour
{
    Toggle cheatToggle;
    Image bg;
    GameObject[] cheatKeys = new GameObject[5];
    public bool cheatIsOpen = false;

    ScreenKeys screenKeys;
    GameObject textPanel;
    ControllerSwitch controllerSwitch;

    private void Awake()
    {
        screenKeys = GameObject.Find("Canvas").transform.GetChild(2).GetComponentInChildren<ScreenKeys>();
        textPanel = GameObject.Find("TextboxPanel");
        controllerSwitch = GameObject.Find("ControllerSwitch").GetComponent<ControllerSwitch>();
        bg = GetComponent<Image>();

        bg.enabled = false;

        for(int i = 0; i <= 4; i++)
        {
            cheatKeys[i] = transform.GetChild(i).gameObject;
            cheatKeys[i].SetActive(false);
        }

        cheatToggle = GameObject.Find("CheatToggle").GetComponent<Toggle>();
        cheatToggle.onValueChanged.AddListener(delegate { OpenCheatSheet(cheatToggle); });
    }

    public void OpenCheatSheet(Toggle toggle)
    {
        bool state = toggle.isOn;
        cheatIsOpen = state;

        print(state);

        bg.enabled = state;
        for (int i = 0; i <= 4; i++)
        {
            cheatKeys[i].SetActive(state);
        }

        SetHintKeys(controllerSwitch.usingGamepad);

        if (screenKeys != null)
        {
            screenKeys.CheatResizeKeys(state);
            ResizeTextbox(state);
        }
    }

    public void SetHintKeys(bool usingGamepad)
    {
        Transform keyHints = transform.Find("KeyHints");

        if(usingGamepad)    //Gamepad hint keys
        {
            keyHints.GetChild(0).gameObject.SetActive(false);
            keyHints.GetChild(1).gameObject.SetActive(true);
        }
        else if(!usingGamepad)  //Keyboard hint keys
        {
            keyHints.GetChild(1).gameObject.SetActive(false);
            keyHints.GetChild(0).gameObject.SetActive(true);
        }
    }

    void ResizeTextbox(bool state)
    {
        RectTransform tbRect = textPanel.GetComponent<RectTransform>();
        RectTransform textBoxField = textPanel.transform.GetChild(1).GetComponent<RectTransform>();
        RectTransform prefaceArea = textPanel.transform.GetChild(2).GetComponent<RectTransform>();

        if (state)
        {
            tbRect.anchoredPosition = new Vector2(0f, 0f);
            tbRect.sizeDelta = new Vector2(450, 400);

            textBoxField.sizeDelta = new Vector2(250, 400);
            prefaceArea.sizeDelta = new Vector2(200, 400);
        }
        else if(!state)
        {
            tbRect.anchoredPosition = new Vector2(50f, 37.5f);
            tbRect.sizeDelta = new Vector2(900, 225);

            textBoxField.sizeDelta = new Vector2(625, 225);
            prefaceArea.sizeDelta = new Vector2(275, 225);
        }
    }

    public void UpdatePresetGroups(LetterGroup letterGroup)
    {
        for (int i = 0; i <= 3; i++)
        {
            Transform t = cheatKeys[i].transform;
            Text[] letters = t.GetComponentsInChildren<Text>();

            for (int j = 0; j <= 8; j++)
            {
                letters[j].text = letterGroup.axisGroup[i][j].ToString();
            }
        }
    }
}
