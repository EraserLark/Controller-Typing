// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""c513071e-c2d1-4cc4-a6ec-d2a2e5172e1c"",
            ""actions"": [
                {
                    ""name"": ""Grow"",
                    ""type"": ""Button"",
                    ""id"": ""70a1578d-16f3-4f85-8b81-1e0a4f04fb5d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""3dbf365d-9b36-4261-8bf7-46709b3ffbb5"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""722cf255-823d-4da3-b171-97fbf93523fc"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""965f3480-01e1-4450-93a3-e84c039c6d12"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53ba45c3-5f33-4b11-9cc3-ece90f6482c0"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27670e57-fc36-4dc3-a3e4-1236adb00cbb"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Typing"",
            ""id"": ""da8cf612-9f36-492d-bd39-03adefe9216d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""225121ad-e436-4f9b-9b24-54880acfc4b2"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""70b30cf0-e980-4b2e-8918-d73efc5a2179"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Backspace"",
                    ""type"": ""Button"",
                    ""id"": ""bf8e3161-b309-403d-84f4-f243c73d2eb5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EastButtonMenu"",
                    ""type"": ""Button"",
                    ""id"": ""c518ef6a-5b9c-46fb-97d5-7f71781c6c5a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7591b34b-4771-4f0f-ba65-b60f210d2d71"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a4546b2-906f-4aac-8523-fe7e67a9f775"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""600ef0ea-beb8-43fe-a166-1a46083b3ecf"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""Backspace"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0126e88-20be-4141-a741-50aab25ece55"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""EastButtonMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad Test"",
            ""bindingGroup"": ""Gamepad Test"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Switch Pro Controller"",
            ""bindingGroup"": ""Switch Pro Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<SwitchProControllerHID>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Grow = m_Gameplay.FindAction("Grow", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Rotate = m_Gameplay.FindAction("Rotate", throwIfNotFound: true);
        // Typing
        m_Typing = asset.FindActionMap("Typing", throwIfNotFound: true);
        m_Typing_Move = m_Typing.FindAction("Move", throwIfNotFound: true);
        m_Typing_Confirm = m_Typing.FindAction("Confirm", throwIfNotFound: true);
        m_Typing_Backspace = m_Typing.FindAction("Backspace", throwIfNotFound: true);
        m_Typing_EastButtonMenu = m_Typing.FindAction("EastButtonMenu", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Grow;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Rotate;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grow => m_Wrapper.m_Gameplay_Grow;
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Rotate => m_Wrapper.m_Gameplay_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Grow.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                @Grow.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                @Grow.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grow.started += instance.OnGrow;
                @Grow.performed += instance.OnGrow;
                @Grow.canceled += instance.OnGrow;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Typing
    private readonly InputActionMap m_Typing;
    private ITypingActions m_TypingActionsCallbackInterface;
    private readonly InputAction m_Typing_Move;
    private readonly InputAction m_Typing_Confirm;
    private readonly InputAction m_Typing_Backspace;
    private readonly InputAction m_Typing_EastButtonMenu;
    public struct TypingActions
    {
        private @PlayerControls m_Wrapper;
        public TypingActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Typing_Move;
        public InputAction @Confirm => m_Wrapper.m_Typing_Confirm;
        public InputAction @Backspace => m_Wrapper.m_Typing_Backspace;
        public InputAction @EastButtonMenu => m_Wrapper.m_Typing_EastButtonMenu;
        public InputActionMap Get() { return m_Wrapper.m_Typing; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TypingActions set) { return set.Get(); }
        public void SetCallbacks(ITypingActions instance)
        {
            if (m_Wrapper.m_TypingActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_TypingActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_TypingActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_TypingActionsCallbackInterface.OnMove;
                @Confirm.started -= m_Wrapper.m_TypingActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_TypingActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_TypingActionsCallbackInterface.OnConfirm;
                @Backspace.started -= m_Wrapper.m_TypingActionsCallbackInterface.OnBackspace;
                @Backspace.performed -= m_Wrapper.m_TypingActionsCallbackInterface.OnBackspace;
                @Backspace.canceled -= m_Wrapper.m_TypingActionsCallbackInterface.OnBackspace;
                @EastButtonMenu.started -= m_Wrapper.m_TypingActionsCallbackInterface.OnEastButtonMenu;
                @EastButtonMenu.performed -= m_Wrapper.m_TypingActionsCallbackInterface.OnEastButtonMenu;
                @EastButtonMenu.canceled -= m_Wrapper.m_TypingActionsCallbackInterface.OnEastButtonMenu;
            }
            m_Wrapper.m_TypingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Backspace.started += instance.OnBackspace;
                @Backspace.performed += instance.OnBackspace;
                @Backspace.canceled += instance.OnBackspace;
                @EastButtonMenu.started += instance.OnEastButtonMenu;
                @EastButtonMenu.performed += instance.OnEastButtonMenu;
                @EastButtonMenu.canceled += instance.OnEastButtonMenu;
            }
        }
    }
    public TypingActions @Typing => new TypingActions(this);
    private int m_GamepadTestSchemeIndex = -1;
    public InputControlScheme GamepadTestScheme
    {
        get
        {
            if (m_GamepadTestSchemeIndex == -1) m_GamepadTestSchemeIndex = asset.FindControlSchemeIndex("Gamepad Test");
            return asset.controlSchemes[m_GamepadTestSchemeIndex];
        }
    }
    private int m_SwitchProControllerSchemeIndex = -1;
    public InputControlScheme SwitchProControllerScheme
    {
        get
        {
            if (m_SwitchProControllerSchemeIndex == -1) m_SwitchProControllerSchemeIndex = asset.FindControlSchemeIndex("Switch Pro Controller");
            return asset.controlSchemes[m_SwitchProControllerSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnGrow(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
    public interface ITypingActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnBackspace(InputAction.CallbackContext context);
        void OnEastButtonMenu(InputAction.CallbackContext context);
    }
}
