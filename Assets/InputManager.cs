using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static PlayerControls typeControls;
    MenuManager menu;

    public bool useGamepad = false;
    private InputActionMap currentMap;

    void Awake()
    {
        typeControls = new PlayerControls();
        menu = GameObject.Find("MenuManager").GetComponent<MenuManager>();

        SetUpActions();

        if (useGamepad)
        {
            typeControls.Typing_Keyboard.Disable();
            typeControls.Typing_Gamepad.Enable();
        }
        else
        {
            typeControls.Typing_Gamepad.Disable();
            typeControls.Typing_Keyboard.Enable();
        }
    }

    void SetUpActions()
    {
        typeControls.Typing_Keyboard.Move.performed += ctx => menu.navigateMenu(ctx.ReadValue<Vector2>());
        typeControls.Typing_Keyboard.Move.canceled += ctx => menu.navigateMenu(Vector2.zero);
        typeControls.Typing_Keyboard.Confirm.performed += ctx => menu.SelectLetter();
        typeControls.Typing_Keyboard.Backspace.performed += ctx => TestInput();
        typeControls.Typing_Keyboard.EastButtonMenu.started += ctx => menu.openMenu(true);
        typeControls.Typing_Keyboard.EastButtonMenu.canceled += ctx => menu.openMenu(false);

        typeControls.Typing_Gamepad.Move.performed += ctx => TestInput();
        typeControls.Typing_Gamepad.Confirm.performed += ctx => TestInput();
        typeControls.Typing_Gamepad.Backspace.performed += ctx => TestInput();
        typeControls.Typing_Gamepad.EastButtonMenu.performed += ctx => TestInput();
    }

    void Update()
    {

    }

    void TestInput()
    {
        print("Input!");
    }
}
