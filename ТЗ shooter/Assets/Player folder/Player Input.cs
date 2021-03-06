// GENERATED AUTOMATICALLY FROM 'Assets/Player folder/Player Input.inputactions'

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
    ""name"": ""Player Input"",
    ""maps"": [
        {
            ""name"": ""Input"",
            ""id"": ""2d104352-dbaa-4cc4-8f5c-e3df8bf42b00"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6db169cd-e0df-4fa9-9fa0-d130f1843e38"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3388811f-df3c-4733-9bfe-31edabe69b13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ca223e1c-8a02-4a2d-abe3-42d91ec54690"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9fa8a419-528e-4ecf-803b-c08edc362475"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Gun1"",
                    ""type"": ""Button"",
                    ""id"": ""7929a7fd-a9a7-4795-8279-8a3cd07c3e6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Gun2"",
                    ""type"": ""Button"",
                    ""id"": ""4fe8b0df-1d02-4922-8448-b7f4194ba5bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Gun3"",
                    ""type"": ""Button"",
                    ""id"": ""efad3601-bdb9-42a8-bb14-e522cf04f8a5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c3fe170c-dd04-4988-9555-005f58362fab"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""244e7a8f-6982-4f23-9620-81a487cfcabb"",
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
                    ""id"": ""4c9994e8-87c8-4354-a6ed-25f0bc1c926e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b5f2b9f0-7d9a-45ca-b561-77e92508b227"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""db859500-f092-494c-aa6e-a6c2b7a0c2a2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2baebf20-96eb-4d72-a688-afb842aa1258"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""be24b994-8617-4c97-991e-7ae737470f9a"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d92c0ae7-0fd7-463c-9962-2aedf3306452"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbafca9b-4853-4723-9aef-70eded01a2f6"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gun1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83f571a0-63d6-428e-a4c8-0652be26fe47"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gun2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73a88475-45b5-4110-9c13-bf024e2a906f"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gun3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Input
        m_Input = asset.FindActionMap("Input", throwIfNotFound: true);
        m_Input_Move = m_Input.FindAction("Move", throwIfNotFound: true);
        m_Input_Shoot = m_Input.FindAction("Shoot", throwIfNotFound: true);
        m_Input_Look = m_Input.FindAction("Look", throwIfNotFound: true);
        m_Input_Jump = m_Input.FindAction("Jump", throwIfNotFound: true);
        m_Input_Gun1 = m_Input.FindAction("Gun1", throwIfNotFound: true);
        m_Input_Gun2 = m_Input.FindAction("Gun2", throwIfNotFound: true);
        m_Input_Gun3 = m_Input.FindAction("Gun3", throwIfNotFound: true);
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

    // Input
    private readonly InputActionMap m_Input;
    private IInputActions m_InputActionsCallbackInterface;
    private readonly InputAction m_Input_Move;
    private readonly InputAction m_Input_Shoot;
    private readonly InputAction m_Input_Look;
    private readonly InputAction m_Input_Jump;
    private readonly InputAction m_Input_Gun1;
    private readonly InputAction m_Input_Gun2;
    private readonly InputAction m_Input_Gun3;
    public struct InputActions
    {
        private @PlayerControls m_Wrapper;
        public InputActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Input_Move;
        public InputAction @Shoot => m_Wrapper.m_Input_Shoot;
        public InputAction @Look => m_Wrapper.m_Input_Look;
        public InputAction @Jump => m_Wrapper.m_Input_Jump;
        public InputAction @Gun1 => m_Wrapper.m_Input_Gun1;
        public InputAction @Gun2 => m_Wrapper.m_Input_Gun2;
        public InputAction @Gun3 => m_Wrapper.m_Input_Gun3;
        public InputActionMap Get() { return m_Wrapper.m_Input; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InputActions set) { return set.Get(); }
        public void SetCallbacks(IInputActions instance)
        {
            if (m_Wrapper.m_InputActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_InputActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnMove;
                @Shoot.started -= m_Wrapper.m_InputActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnShoot;
                @Look.started -= m_Wrapper.m_InputActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_InputActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnJump;
                @Gun1.started -= m_Wrapper.m_InputActionsCallbackInterface.OnGun1;
                @Gun1.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnGun1;
                @Gun1.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnGun1;
                @Gun2.started -= m_Wrapper.m_InputActionsCallbackInterface.OnGun2;
                @Gun2.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnGun2;
                @Gun2.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnGun2;
                @Gun3.started -= m_Wrapper.m_InputActionsCallbackInterface.OnGun3;
                @Gun3.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnGun3;
                @Gun3.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnGun3;
            }
            m_Wrapper.m_InputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Gun1.started += instance.OnGun1;
                @Gun1.performed += instance.OnGun1;
                @Gun1.canceled += instance.OnGun1;
                @Gun2.started += instance.OnGun2;
                @Gun2.performed += instance.OnGun2;
                @Gun2.canceled += instance.OnGun2;
                @Gun3.started += instance.OnGun3;
                @Gun3.performed += instance.OnGun3;
                @Gun3.canceled += instance.OnGun3;
            }
        }
    }
    public InputActions @Input => new InputActions(this);
    public interface IInputActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnGun1(InputAction.CallbackContext context);
        void OnGun2(InputAction.CallbackContext context);
        void OnGun3(InputAction.CallbackContext context);
    }
}
