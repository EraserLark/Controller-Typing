using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static PlayerControls typeControls;
    MenuManager menu;
    BasicTextbox basicTB;

    public bool useGamepad = false;
    private InputActionMap currentMap;

    enum AxisButtons { North, East, South, West };
    AxisButtons axisButtons;

    void Awake()
    {
        typeControls = new PlayerControls();
        menu = GameObject.Find("MenuManager").GetComponent<MenuManager>();
        basicTB = GameObject.Find("BasicTextbox").GetComponent<BasicTextbox>();

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
        typeControls.Typing_Keyboard.Backspace.performed += ctx => basicTB.deleteLetter();

        typeControls.Typing_Keyboard.NorthButtonMenu.started += ctx => menu.openMenu(true, (int)AxisButtons.North);
        typeControls.Typing_Keyboard.NorthButtonMenu.canceled += ctx => menu.openMenu(false, (int)AxisButtons.North);

        typeControls.Typing_Keyboard.EastButtonMenu.started += ctx => menu.openMenu(true, (int)AxisButtons.East);
        typeControls.Typing_Keyboard.EastButtonMenu.canceled += ctx => menu.openMenu(false, (int)AxisButtons.East);

        typeControls.Typing_Keyboard.SouthButtonMenu.started += ctx => menu.openMenu(true, (int)AxisButtons.South);
        typeControls.Typing_Keyboard.SouthButtonMenu.canceled += ctx => menu.openMenu(false, (int)AxisButtons.South);

        typeControls.Typing_Keyboard.WestButtonMenu.started += ctx => menu.openMenu(true, (int)AxisButtons.West);
        typeControls.Typing_Keyboard.WestButtonMenu.canceled += ctx => menu.openMenu(false, (int)AxisButtons.West);
        //typeControls.Typing_Keyboard.EastButtonMenu.started += ctx => menu.openMenu(ctx.ReadValue<Single>());
        //typeControls.Typing_Keyboard.EastButtonMenu.canceled += ctx => menu.openMenu(ctx.ReadValue<Single>());

        typeControls.Typing_Gamepad.Move.performed += ctx => TestInput();
        typeControls.Typing_Gamepad.Confirm.performed += ctx => TestInput();
        typeControls.Typing_Gamepad.Backspace.performed += ctx => TestInput();
        typeControls.Typing_Gamepad.EastButtonMenu.performed += ctx => TestInput();
    }

    void TestInput()
    {
        print("Input!");
    }
}
