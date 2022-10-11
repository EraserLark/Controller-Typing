using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static PlayerControls typeControls;
    //public static event Action<InputActionMap> actionMapChange;

    public bool useGamepad = false;
    private InputActionMap currentMap;

    public event EventHandler<InputAction> inputDetected;   //Creating signal, parameters

    void Awake()
    {
        typeControls = new PlayerControls();
        
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
        typeControls.Typing_Keyboard.Move.performed += ctx => TestInput();
        typeControls.Typing_Keyboard.Confirm.performed += ctx => TestInput();
        typeControls.Typing_Keyboard.Backspace.performed += ctx => TestInput();
        typeControls.Typing_Keyboard.EastButtonMenu.performed += ctx => TestInput();

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

    public void OnInputDetected(InputAction input)
    {
        inputDetected?.Invoke(this, input); //Fire signal
    }
}
