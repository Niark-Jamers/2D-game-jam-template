// GENERATED AUTOMATICALLY FROM 'Assets/Others/Inputs/CharacterInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CharacterInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CharacterInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CharacterInputs"",
    ""maps"": [
        {
            ""name"": ""SideView"",
            ""id"": ""13c3dc1c-9725-4d99-9b9f-237dfaa42d76"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""20254a52-4b42-4406-a5d6-dcbc84ee890e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""080368a3-134f-4398-bbe4-5deec0e381c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f92db221-ebd7-4196-8e8b-d09f38e104a5"",
                    ""path"": ""<Joystick>/stick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81897202-570d-4740-9044-4674f397e78b"",
                    ""path"": ""<Touchscreen>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard Arrow"",
                    ""id"": ""77de23ce-9ef4-4004-9b2b-a0923eefcd91"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""093de14e-0c04-413a-962c-6119bad45d96"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""67a04825-1942-4ceb-94ac-89e5ada6f434"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard AD"",
                    ""id"": ""7573336f-9a38-4e1e-b7b7-1fb3385b9e16"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""85ed41a2-5799-416a-835a-3216dc258233"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c2f2c960-00d5-419f-bd60-7d655f306c7a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2db582cb-7f5f-4bcc-b5c7-ca3f2870aeee"",
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
                    ""id"": ""869de806-c3ed-4034-afae-afd3385071c0"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TopDown"",
            ""id"": ""353acfa9-4e52-47cb-acb3-d40aee19a313"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""3f837575-e2d8-44b6-8788-63c591e68b88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0f1bccef-c555-4ef2-93b4-5d7bcdd13725"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54a76b29-f863-4596-b977-650ea2732b06"",
                    ""path"": ""<AndroidGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard WASD"",
                    ""id"": ""087668b1-303f-4ace-b8de-59f1d62f92c5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c02b016f-1d0b-4ff4-9bf2-90310f1c88d9"",
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
                    ""id"": ""c93631c0-fa34-4d7a-ab48-36e0897fb2dd"",
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
                    ""id"": ""b7ecbfaf-6ed5-40e1-9d92-668fa0375de8"",
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
                    ""id"": ""4bd05122-fb09-40cb-b8e6-87f0258fa4fa"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard Arrow"",
                    ""id"": ""8ae4b1e8-95af-421d-9b48-e542c756033f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c3eea530-93bd-4692-ad86-f427a978c777"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""58e1e647-f4f9-4b2c-ba6d-e1dc3a8f1585"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""03f4ba54-c3c4-4a00-8518-02b66f4b253c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4ad56ba3-0f64-4293-b12c-d49035b1f097"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // SideView
        m_SideView = asset.FindActionMap("SideView", throwIfNotFound: true);
        m_SideView_Movement = m_SideView.FindAction("Movement", throwIfNotFound: true);
        m_SideView_Jump = m_SideView.FindAction("Jump", throwIfNotFound: true);
        // TopDown
        m_TopDown = asset.FindActionMap("TopDown", throwIfNotFound: true);
        m_TopDown_Movement = m_TopDown.FindAction("Movement", throwIfNotFound: true);
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

    // SideView
    private readonly InputActionMap m_SideView;
    private ISideViewActions m_SideViewActionsCallbackInterface;
    private readonly InputAction m_SideView_Movement;
    private readonly InputAction m_SideView_Jump;
    public struct SideViewActions
    {
        private @CharacterInputs m_Wrapper;
        public SideViewActions(@CharacterInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_SideView_Movement;
        public InputAction @Jump => m_Wrapper.m_SideView_Jump;
        public InputActionMap Get() { return m_Wrapper.m_SideView; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SideViewActions set) { return set.Get(); }
        public void SetCallbacks(ISideViewActions instance)
        {
            if (m_Wrapper.m_SideViewActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_SideViewActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_SideViewActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_SideViewActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_SideViewActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_SideViewActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_SideViewActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_SideViewActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public SideViewActions @SideView => new SideViewActions(this);

    // TopDown
    private readonly InputActionMap m_TopDown;
    private ITopDownActions m_TopDownActionsCallbackInterface;
    private readonly InputAction m_TopDown_Movement;
    public struct TopDownActions
    {
        private @CharacterInputs m_Wrapper;
        public TopDownActions(@CharacterInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_TopDown_Movement;
        public InputActionMap Get() { return m_Wrapper.m_TopDown; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TopDownActions set) { return set.Get(); }
        public void SetCallbacks(ITopDownActions instance)
        {
            if (m_Wrapper.m_TopDownActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_TopDownActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_TopDownActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_TopDownActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_TopDownActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public TopDownActions @TopDown => new TopDownActions(this);
    public interface ISideViewActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface ITopDownActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
