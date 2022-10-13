using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerSwitch : MonoBehaviour
{
    bool usingGamepad = false;
    enum Controllers {Keyboard, Gamepad};
    Controllers currentController = Controllers.Keyboard;

    InputManager inputManager;

    Image buttonBG;
    Image buttonIcon;
    Text buttonText;
    GameObject gamepadUIText;
    public Sprite sprKeyboard;
    public Sprite sprGamepad;

    private void Awake()
    {
        inputManager = GameObject.Find("InputManager").GetComponent<InputManager>();

        buttonBG = gameObject.GetComponent<Image>();
        buttonBG.color = Color.blue;
        buttonIcon = transform.GetChild(1).GetComponent<Image>();
        buttonText = transform.GetComponentInChildren<Text>();
        gamepadUIText = transform.GetChild(2).gameObject;
        gamepadUIText.SetActive(false);
    }

    public void ButtonClick()
    {
        usingGamepad = !usingGamepad;
        inputManager.switchToGamepad(usingGamepad);
        gamepadUIText.SetActive(usingGamepad);

        int intState = Convert.ToInt32(usingGamepad);
        currentController = (Controllers)intState;
        SwitchButtonDetails(currentController);
    }

    void SwitchButtonDetails(Controllers currentControls)
    {
        if(currentControls == Controllers.Keyboard)
        {
            buttonBG.color = Color.blue;
            buttonIcon.sprite = sprKeyboard;
            buttonText.text = "Keyboard";
        }
        else if(currentControls == Controllers.Gamepad)
        {
            buttonBG.color = Color.red;
            buttonIcon.sprite = sprGamepad;
            buttonText.text = "Gamepad";
        }
    }

    public void updateGamepadName(string name)
    {
        gamepadUIText.GetComponent<Text>().text = "Gamepad: " + name;
    }
}
