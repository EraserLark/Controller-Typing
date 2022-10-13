// GENERATED AUTOMATICALLY FROM 'Assets/2021/PlayerControls.inputactions'

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
            ""name"": ""Typing_Gamepad"",
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
                },
                {
                    ""name"": ""NorthButtonMenu"",
                    ""type"": ""Button"",
                    ""id"": ""ed95f99c-f271-481a-be9b-064811928e47"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SouthButtonMenu"",
                    ""type"": ""Button"",
                    ""id"": ""77371ca8-83dd-4d57-bebc-22dad94fbebd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WestButtonMenu"",
                    ""type"": ""Button"",
                    ""id"": ""8d3b9da3-163c-424d-bb44-2a4c7dc72916"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""39c8a012-63c0-4b6e-8369-b01bb5155962"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""752ba421-04fc-4dcc-892c-ba0bacb561d1"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test;Switch Pro Controller"",
                    ""action"": ""NorthButtonMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1ff375e-8311-44ff-92a9-58a3087f2153"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""SouthButtonMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cebcc831-a9b7-419f-9c7a-d736b215b650"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""WestButtonMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b689a21-fbf7-4568-bce5-ad36029110cd"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Typing_Keyboard"",
            ""id"": ""4c7a9ec4-945e-462c-9a02-77ddb1c627c8"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""eb64fd87-577c-46b7-992d-63bb28c6edfc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""66772e2c-3e34-40b9-9081-0ee2126e1ce7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Backspace"",
                    ""type"": ""Button"",
                    ""id"": ""63311fc1-0068-4d57-94fb-a0ba2f94e822"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EastButtonMenu"",
                    ""type"": ""Button"",
                    ""id"": ""7052b80f-adcf-477e-8fc7-cca210aee3c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NorthButtonMenu"",
                    ""type"": ""Button"",
                    ""id"": ""1765ed1f-5ae2-4775-b91c-b57db91cbb61"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SouthButtonMenu"",
                    ""type"": ""Button"",
                    ""id"": ""1b499c2c-bf1d-4722-b2dc-6864514a3fb6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WestButtonMenu"",
                    ""type"": ""Button"",
                    ""id"": ""42eb162d-b81f-45e6-81e0-decf35c1a5d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""41c9dd2d-045d-45c8-8c2f-2c0bb19c929f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b204530e-c94a-4e8b-b92e-5d837336320c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd8a8b63-562c-4551-ba1c-25a0d0048d47"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""Backspace"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""823911ef-172c-4594-a8bf-8169f25a0495"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""EastButtonMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""dc41eef4-4806-47ca-8f0c-0bc54e91cc39"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b7dfceaa-7bc3-472c-8fc6-4f9309fe43c9"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dd690018-54c7-4816-9a31-8a2690f41be9"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7a7b6711-4a97-4a92-a237-bbfebcf4a02f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b0d498a7-79e2-4ed8-8afc-4b88ea218918"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e81e6df8-33ce-436e-ba12-85ebe7cc2b1b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""NorthButtonMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""991b7dd6-9c36-4964-abd9-f6079d9c8ff9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""SouthButtonMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2818739d-14e3-4d55-9bf3-c872f449526c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""WestButtonMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b0b2a26-f2ec-4db4-b7ef-fa50933ef98b"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Test"",
                    ""action"": ""Submit"",
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
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
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
        // Typing_Gamepad
        m_Typing_Gamepad = asset.FindActionMap("Typing_Gamepad", throwIfNotFound: true);
        m_Typing_Gamepad_Move = m_Typing_Gamepad.FindAction("Move", throwIfNotFound: true);
        m_Typing_Gamepad_Confirm = m_Typing_Gamepad.FindAction("Confirm", throwIfNotFound: true);
        m_Typing_Gamepad_Backspace = m_Typing_Gamepad.FindAction("Backspace", throwIfNotFound: true);
        m_Typing_Gamepad_EastButtonMenu = m_Typing_Gamepad.FindAction("EastButtonMenu", throwIfNotFound: true);
        m_Typing_Gamepad_NorthButtonMenu = m_Typing_Gamepad.FindAction("NorthButtonMenu", throwIfNotFound: true);
        m_Typing_Gamepad_SouthButtonMenu = m_Typing_Gamepad.FindAction("SouthButtonMenu", throwIfNotFound: true);
        m_Typing_Gamepad_WestButtonMenu = m_Typing_Gamepad.FindAction("WestButtonMenu", throwIfNotFound: true);
        m_Typing_Gamepad_Submit = m_Typing_Gamepad.FindAction("Submit", throwIfNotFound: true);
        // Typing_Keyboard
        m_Typing_Keyboard = asset.FindActionMap("Typing_Keyboard", throwIfNotFound: true);
        m_Typing_Keyboard_Move = m_Typing_Keyboard.FindAction("Move", throwIfNotFound: true);
        m_Typing_Keyboard_Confirm = m_Typing_Keyboard.FindAction("Confirm", throwIfNotFound: true);
        m_Typing_Keyboard_Backspace = m_Typing_Keyboard.FindAction("Backspace", throwIfNotFound: true);
        m_Typing_Keyboard_EastButtonMenu = m_Typing_Keyboard.FindAction("EastButtonMenu", throwIfNotFound: true);
        m_Typing_Keyboard_NorthButtonMenu = m_Typing_Keyboard.FindAction("NorthButtonMenu", throwIfNotFound: true);
        m_Typing_Keyboard_SouthButtonMenu = m_Typing_Keyboard.FindAction("SouthButtonMenu", throwIfNotFound: true);
        m_Typing_Keyboard_WestButtonMenu = m_Typing_Keyboard.FindAction("WestButtonMenu", throwIfNotFound: true);
        m_Typing_Keyboard_Submit = m_Typing_Keyboard.FindAction("Submit", throwIfNotFound: true);
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

    // Typing_Gamepad
    private readonly InputActionMap m_Typing_Gamepad;
    private ITyping_GamepadActions m_Typing_GamepadActionsCallbackInterface;
    private readonly InputAction m_Typing_Gamepad_Move;
    private readonly InputAction m_Typing_Gamepad_Confirm;
    private readonly InputAction m_Typing_Gamepad_Backspace;
    private readonly InputAction m_Typing_Gamepad_EastButtonMenu;
    private readonly InputAction m_Typing_Gamepad_NorthButtonMenu;
    private readonly InputAction m_Typing_Gamepad_SouthButtonMenu;
    private readonly InputAction m_Typing_Gamepad_WestButtonMenu;
    private readonly InputAction m_Typing_Gamepad_Submit;
    public struct Typing_GamepadActions
    {
        private @PlayerControls m_Wrapper;
        public Typing_GamepadActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Typing_Gamepad_Move;
        public InputAction @Confirm => m_Wrapper.m_Typing_Gamepad_Confirm;
        public InputAction @Backspace => m_Wrapper.m_Typing_Gamepad_Backspace;
        public InputAction @EastButtonMenu => m_Wrapper.m_Typing_Gamepad_EastButtonMenu;
        public InputAction @NorthButtonMenu => m_Wrapper.m_Typing_Gamepad_NorthButtonMenu;
        public InputAction @SouthButtonMenu => m_Wrapper.m_Typing_Gamepad_SouthButtonMenu;
        public InputAction @WestButtonMenu => m_Wrapper.m_Typing_Gamepad_WestButtonMenu;
        public InputAction @Submit => m_Wrapper.m_Typing_Gamepad_Submit;
        public InputActionMap Get() { return m_Wrapper.m_Typing_Gamepad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Typing_GamepadActions set) { return set.Get(); }
        public void SetCallbacks(ITyping_GamepadActions instance)
        {
            if (m_Wrapper.m_Typing_GamepadActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnMove;
                @Confirm.started -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnConfirm;
                @Backspace.started -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnBackspace;
                @Backspace.performed -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnBackspace;
                @Backspace.canceled -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnBackspace;
                @EastButtonMenu.started -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnEastButtonMenu;
                @EastButtonMenu.performed -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnEastButtonMenu;
                @EastButtonMenu.canceled -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnEastButtonMenu;
                @NorthButtonMenu.started -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnNorthButtonMenu;
                @NorthButtonMenu.performed -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnNorthButtonMenu;
                @NorthButtonMenu.canceled -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnNorthButtonMenu;
                @SouthButtonMenu.started -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnSouthButtonMenu;
                @SouthButtonMenu.performed -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnSouthButtonMenu;
                @SouthButtonMenu.canceled -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnSouthButtonMenu;
                @WestButtonMenu.started -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnWestButtonMenu;
                @WestButtonMenu.performed -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnWestButtonMenu;
                @WestButtonMenu.canceled -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnWestButtonMenu;
                @Submit.started -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_Typing_GamepadActionsCallbackInterface.OnSubmit;
            }
            m_Wrapper.m_Typing_GamepadActionsCallbackInterface = instance;
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
                @NorthButtonMenu.started += instance.OnNorthButtonMenu;
                @NorthButtonMenu.performed += instance.OnNorthButtonMenu;
                @NorthButtonMenu.canceled += instance.OnNorthButtonMenu;
                @SouthButtonMenu.started += instance.OnSouthButtonMenu;
                @SouthButtonMenu.performed += instance.OnSouthButtonMenu;
                @SouthButtonMenu.canceled += instance.OnSouthButtonMenu;
                @WestButtonMenu.started += instance.OnWestButtonMenu;
                @WestButtonMenu.performed += instance.OnWestButtonMenu;
                @WestButtonMenu.canceled += instance.OnWestButtonMenu;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
            }
        }
    }
    public Typing_GamepadActions @Typing_Gamepad => new Typing_GamepadActions(this);

    // Typing_Keyboard
    private readonly InputActionMap m_Typing_Keyboard;
    private ITyping_KeyboardActions m_Typing_KeyboardActionsCallbackInterface;
    private readonly InputAction m_Typing_Keyboard_Move;
    private readonly InputAction m_Typing_Keyboard_Confirm;
    private readonly InputAction m_Typing_Keyboard_Backspace;
    private readonly InputAction m_Typing_Keyboard_EastButtonMenu;
    private readonly InputAction m_Typing_Keyboard_NorthButtonMenu;
    private readonly InputAction m_Typing_Keyboard_SouthButtonMenu;
    private readonly InputAction m_Typing_Keyboard_WestButtonMenu;
    private readonly InputAction m_Typing_Keyboard_Submit;
    public struct Typing_KeyboardActions
    {
        private @PlayerControls m_Wrapper;
        public Typing_KeyboardActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Typing_Keyboard_Move;
        public InputAction @Confirm => m_Wrapper.m_Typing_Keyboard_Confirm;
        public InputAction @Backspace => m_Wrapper.m_Typing_Keyboard_Backspace;
        public InputAction @EastButtonMenu => m_Wrapper.m_Typing_Keyboard_EastButtonMenu;
        public InputAction @NorthButtonMenu => m_Wrapper.m_Typing_Keyboard_NorthButtonMenu;
        public InputAction @SouthButtonMenu => m_Wrapper.m_Typing_Keyboard_SouthButtonMenu;
        public InputAction @WestButtonMenu => m_Wrapper.m_Typing_Keyboard_WestButtonMenu;
        public InputAction @Submit => m_Wrapper.m_Typing_Keyboard_Submit;
        public InputActionMap Get() { return m_Wrapper.m_Typing_Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Typing_KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(ITyping_KeyboardActions instance)
        {
            if (m_Wrapper.m_Typing_KeyboardActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnMove;
                @Confirm.started -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnConfirm;
                @Backspace.started -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnBackspace;
                @Backspace.performed -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnBackspace;
                @Backspace.canceled -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnBackspace;
                @EastButtonMenu.started -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnEastButtonMenu;
                @EastButtonMenu.performed -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnEastButtonMenu;
                @EastButtonMenu.canceled -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnEastButtonMenu;
                @NorthButtonMenu.started -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnNorthButtonMenu;
                @NorthButtonMenu.performed -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnNorthButtonMenu;
                @NorthButtonMenu.canceled -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnNorthButtonMenu;
                @SouthButtonMenu.started -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnSouthButtonMenu;
                @SouthButtonMenu.performed -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnSouthButtonMenu;
                @SouthButtonMenu.canceled -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnSouthButtonMenu;
                @WestButtonMenu.started -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnWestButtonMenu;
                @WestButtonMenu.performed -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnWestButtonMenu;
                @WestButtonMenu.canceled -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnWestButtonMenu;
                @Submit.started -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_Typing_KeyboardActionsCallbackInterface.OnSubmit;
            }
            m_Wrapper.m_Typing_KeyboardActionsCallbackInterface = instance;
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
                @NorthButtonMenu.started += instance.OnNorthButtonMenu;
                @NorthButtonMenu.performed += instance.OnNorthButtonMenu;
                @NorthButtonMenu.canceled += instance.OnNorthButtonMenu;
                @SouthButtonMenu.started += instance.OnSouthButtonMenu;
                @SouthButtonMenu.performed += instance.OnSouthButtonMenu;
                @SouthButtonMenu.canceled += instance.OnSouthButtonMenu;
                @WestButtonMenu.started += instance.OnWestButtonMenu;
                @WestButtonMenu.performed += instance.OnWestButtonMenu;
                @WestButtonMenu.canceled += instance.OnWestButtonMenu;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
            }
        }
    }
    public Typing_KeyboardActions @Typing_Keyboard => new Typing_KeyboardActions(this);
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
    public interface ITyping_GamepadActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnBackspace(InputAction.CallbackContext context);
        void OnEastButtonMenu(InputAction.CallbackContext context);
        void OnNorthButtonMenu(InputAction.CallbackContext context);
        void OnSouthButtonMenu(InputAction.CallbackContext context);
        void OnWestButtonMenu(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
    }
    public interface ITyping_KeyboardActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnBackspace(InputAction.CallbackContext context);
        void OnEastButtonMenu(InputAction.CallbackContext context);
        void OnNorthButtonMenu(InputAction.CallbackContext context);
        void OnSouthButtonMenu(InputAction.CallbackContext context);
        void OnWestButtonMenu(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
    }
}
