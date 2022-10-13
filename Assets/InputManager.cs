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
    ControllerSwitch controllerSwitch;

    public bool useGamepad = false;
    private InputActionMap currentMap;

    enum AxisButtons { North, East, South, West };

    void Awake()
    {
        typeControls = new PlayerControls();
        menu = GameObject.Find("MenuManager").GetComponent<MenuManager>();
        basicTB = GameObject.Find("BasicTextbox").GetComponent<BasicTextbox>();
        controllerSwitch = GameObject.Find("ControllerSwitch").GetComponent<ControllerSwitch>();

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

        if(Gamepad.current != null)
        {
            controllerSwitch.updateGamepadName(Gamepad.current.name);
        }

        //https://docs.unity3d.com/Packages/com.unity.inputsystem@1.4/manual/HowDoI.html#find-all-connected-gamepads
        InputSystem.onDeviceChange +=
        (device, change) =>
        {
            switch (change)
            {
                case InputDeviceChange.Added:
                    // New Device.
                    controllerSwitch.updateGamepadName(device.name);
                    break;
                case InputDeviceChange.Disconnected:
                    controllerSwitch.updateGamepadName("No Gamepad connected!");
                    break;
                case InputDeviceChange.Reconnected:
                    controllerSwitch.updateGamepadName(device.name);
                    break;
                default:
                    break;
            }
        };
    }

    public void switchToGamepad(bool state)
    {
        if(state)
        {
            typeControls.Typing_Keyboard.Disable();
            typeControls.Typing_Gamepad.Enable();
        }
        else if (!state)
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
        typeControls.Typing_Keyboard.Submit.performed += ctx => basicTB.submitMessage();


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

        /*
        typeControls.Typing_Gamepad.Move.performed += ctx => TestInput();
        typeControls.Typing_Gamepad.Confirm.performed += ctx => TestInput();
        typeControls.Typing_Gamepad.Backspace.performed += ctx => TestInput();
        typeControls.Typing_Gamepad.EastButtonMenu.performed += ctx => TestInput();
        */

        typeControls.Typing_Gamepad.Move.performed += ctx => menu.navigateMenu(ctx.ReadValue<Vector2>());
        typeControls.Typing_Gamepad.Move.canceled += ctx => menu.navigateMenu(Vector2.zero);
        typeControls.Typing_Gamepad.Confirm.performed += ctx => menu.SelectLetter();
        typeControls.Typing_Gamepad.Backspace.performed += ctx => basicTB.deleteLetter();
        typeControls.Typing_Gamepad.Submit.performed += ctx => basicTB.submitMessage();

        typeControls.Typing_Gamepad.NorthButtonMenu.started += ctx => menu.openMenu(true, (int)AxisButtons.North);
        typeControls.Typing_Gamepad.NorthButtonMenu.canceled += ctx => menu.openMenu(false, (int)AxisButtons.North);

        typeControls.Typing_Gamepad.EastButtonMenu.started += ctx => menu.openMenu(true, (int)AxisButtons.East);
        typeControls.Typing_Gamepad.EastButtonMenu.canceled += ctx => menu.openMenu(false, (int)AxisButtons.East);

        typeControls.Typing_Gamepad.SouthButtonMenu.started += ctx => menu.openMenu(true, (int)AxisButtons.South);
        typeControls.Typing_Gamepad.SouthButtonMenu.canceled += ctx => menu.openMenu(false, (int)AxisButtons.South);

        typeControls.Typing_Gamepad.WestButtonMenu.started += ctx => menu.openMenu(true, (int)AxisButtons.West);
        typeControls.Typing_Gamepad.WestButtonMenu.canceled += ctx => menu.openMenu(false, (int)AxisButtons.West);
    }

    void TestInput()
    {
        print("Input!");
    }
}
