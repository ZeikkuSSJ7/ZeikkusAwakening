// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputSystem/PlayerControls.inputactions'

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
            ""name"": ""Player Movement"",
            ""id"": ""c4a90b4b-286d-417c-88a8-0d9b3a9d73aa"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2da53bdf-0342-457b-bc38-bd1d613154e2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3b689f83-311d-4149-a4fc-c13c3fc1e901"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""b11f9f83-0cf7-4da8-ba93-73597ee516dd"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ec1bac39-477d-4791-8e4d-75015da6cb2e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b76d98ae-4c98-4449-bf85-6456653aced2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9ed9821e-2ceb-4869-9ea6-027916bf2da6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0876436e-c58f-48cf-8b2c-4603e6eddcef"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Stick"",
                    ""id"": ""40bccb8d-5fe4-462b-b8eb-c9f1fbf27b06"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7573a30d-f6ba-4123-b748-5189421436fa"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9df361ab-6156-4c5a-924f-42314a1a14ad"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bc0de574-32b3-459d-83dc-f630d3236a9e"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7c998d1b-72f5-41a1-977f-a1cd50d5a7a0"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right Stick"",
                    ""id"": ""ff1912bc-e439-4216-a0be-3e36a6fec0d5"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""032399f9-513b-40a6-ad46-06e47904138a"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2c64425d-037d-403d-8f69-ac723c48bad8"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""276fa486-0240-445f-99af-0a079b94ab01"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c2b3570f-8ccb-4b24-bd2c-c64c5b26cb98"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player Actions"",
            ""id"": ""fab21fec-a62f-4fb4-b608-dde2d9452b12"",
            ""actions"": [
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""c2a1e068-7655-4c1f-a8bf-1f5fe8461ff9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""33734746-7eea-4ec1-b159-2a94f3fd0f07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""b6da6e13-6713-400e-a01e-1c72b61c434c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""689e5e20-8ac3-4777-8ce0-e6e83761e201"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""63c17f0b-6757-445b-8586-9344e10d88f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""fc8adb33-b1d1-470c-b569-92de388cb18e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""87c68b2d-d8c8-4e68-b7f1-f9011c6ccc31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L Trigger"",
                    ""type"": ""Button"",
                    ""id"": ""ad9dee02-df15-45c2-a5a9-e47762df15a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R Trigger"",
                    ""type"": ""Button"",
                    ""id"": ""8c3e0dea-9fb5-4847-8df9-d37a8c5ec7cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R Bump"",
                    ""type"": ""Button"",
                    ""id"": ""890d853c-0019-4b40-88ed-890d840a3f2e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L Bump"",
                    ""type"": ""Button"",
                    ""id"": ""ff92b1e9-41b1-40e3-8ac6-361d9e4c8bdb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a483611c-9e73-4624-a7d9-55995cd19e6c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55826b04-7eb5-43e3-a52a-a73142adb8f7"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd7b420b-8c2a-4ebb-8dab-57419ff6fc7f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9cfeb6f7-e910-4575-8187-5051c537b305"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41f76aee-ca95-4e23-9eaa-6feebf537b69"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e50bf313-130f-4997-ab68-0408a29ecd21"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R Bump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33381269-454f-4b81-86b2-fa11467afb15"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f981cb3-7213-472c-8255-1800ccb6df12"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67b05fec-124b-4ce7-8ed5-7e2cb3eaa9d7"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L Bump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49ca2ada-bf88-41c1-b115-8c892f1efe00"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1874fba2-18e0-4322-9c8f-3d2a85613c1f"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f74685c2-4bcf-43eb-b189-4b74ba5ca355"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44f3e00b-90c2-4a68-a11c-8a8e40ebd525"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player Movement
        m_PlayerMovement = asset.FindActionMap("Player Movement", throwIfNotFound: true);
        m_PlayerMovement_Movement = m_PlayerMovement.FindAction("Movement", throwIfNotFound: true);
        m_PlayerMovement_Camera = m_PlayerMovement.FindAction("Camera", throwIfNotFound: true);
        // Player Actions
        m_PlayerActions = asset.FindActionMap("Player Actions", throwIfNotFound: true);
        m_PlayerActions_B = m_PlayerActions.FindAction("B", throwIfNotFound: true);
        m_PlayerActions_Jump = m_PlayerActions.FindAction("Jump", throwIfNotFound: true);
        m_PlayerActions_A = m_PlayerActions.FindAction("A", throwIfNotFound: true);
        m_PlayerActions_Y = m_PlayerActions.FindAction("Y", throwIfNotFound: true);
        m_PlayerActions_X = m_PlayerActions.FindAction("X", throwIfNotFound: true);
        m_PlayerActions_Start = m_PlayerActions.FindAction("Start", throwIfNotFound: true);
        m_PlayerActions_Select = m_PlayerActions.FindAction("Select", throwIfNotFound: true);
        m_PlayerActions_LTrigger = m_PlayerActions.FindAction("L Trigger", throwIfNotFound: true);
        m_PlayerActions_RTrigger = m_PlayerActions.FindAction("R Trigger", throwIfNotFound: true);
        m_PlayerActions_RBump = m_PlayerActions.FindAction("R Bump", throwIfNotFound: true);
        m_PlayerActions_LBump = m_PlayerActions.FindAction("L Bump", throwIfNotFound: true);
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

    // Player Movement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Movement;
    private readonly InputAction m_PlayerMovement_Camera;
    public struct PlayerMovementActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerMovement_Movement;
        public InputAction @Camera => m_Wrapper.m_PlayerMovement_Camera;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Camera.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // Player Actions
    private readonly InputActionMap m_PlayerActions;
    private IPlayerActionsActions m_PlayerActionsActionsCallbackInterface;
    private readonly InputAction m_PlayerActions_B;
    private readonly InputAction m_PlayerActions_Jump;
    private readonly InputAction m_PlayerActions_A;
    private readonly InputAction m_PlayerActions_Y;
    private readonly InputAction m_PlayerActions_X;
    private readonly InputAction m_PlayerActions_Start;
    private readonly InputAction m_PlayerActions_Select;
    private readonly InputAction m_PlayerActions_LTrigger;
    private readonly InputAction m_PlayerActions_RTrigger;
    private readonly InputAction m_PlayerActions_RBump;
    private readonly InputAction m_PlayerActions_LBump;
    public struct PlayerActionsActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @B => m_Wrapper.m_PlayerActions_B;
        public InputAction @Jump => m_Wrapper.m_PlayerActions_Jump;
        public InputAction @A => m_Wrapper.m_PlayerActions_A;
        public InputAction @Y => m_Wrapper.m_PlayerActions_Y;
        public InputAction @X => m_Wrapper.m_PlayerActions_X;
        public InputAction @Start => m_Wrapper.m_PlayerActions_Start;
        public InputAction @Select => m_Wrapper.m_PlayerActions_Select;
        public InputAction @LTrigger => m_Wrapper.m_PlayerActions_LTrigger;
        public InputAction @RTrigger => m_Wrapper.m_PlayerActions_RTrigger;
        public InputAction @RBump => m_Wrapper.m_PlayerActions_RBump;
        public InputAction @LBump => m_Wrapper.m_PlayerActions_LBump;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @B.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnB;
                @Jump.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnJump;
                @A.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnA;
                @Y.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnY;
                @X.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnX;
                @Start.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnStart;
                @Select.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnSelect;
                @LTrigger.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLTrigger;
                @LTrigger.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLTrigger;
                @LTrigger.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLTrigger;
                @RTrigger.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRTrigger;
                @RTrigger.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRTrigger;
                @RTrigger.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRTrigger;
                @RBump.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRBump;
                @RBump.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRBump;
                @RBump.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRBump;
                @LBump.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLBump;
                @LBump.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLBump;
                @LBump.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLBump;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @LTrigger.started += instance.OnLTrigger;
                @LTrigger.performed += instance.OnLTrigger;
                @LTrigger.canceled += instance.OnLTrigger;
                @RTrigger.started += instance.OnRTrigger;
                @RTrigger.performed += instance.OnRTrigger;
                @RTrigger.canceled += instance.OnRTrigger;
                @RBump.started += instance.OnRBump;
                @RBump.performed += instance.OnRBump;
                @RBump.canceled += instance.OnRBump;
                @LBump.started += instance.OnLBump;
                @LBump.performed += instance.OnLBump;
                @LBump.canceled += instance.OnLBump;
            }
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);
    public interface IPlayerMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
    }
    public interface IPlayerActionsActions
    {
        void OnB(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnLTrigger(InputAction.CallbackContext context);
        void OnRTrigger(InputAction.CallbackContext context);
        void OnRBump(InputAction.CallbackContext context);
        void OnLBump(InputAction.CallbackContext context);
    }
}
