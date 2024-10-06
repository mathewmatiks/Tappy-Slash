//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Inputs/IA_Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @IA_Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @IA_Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""IA_Controls"",
    ""maps"": [
        {
            ""name"": ""Mouse Controls"",
            ""id"": ""0535c12b-9e02-489a-bdbf-3278db7aa5a4"",
            ""actions"": [
                {
                    ""name"": ""Press"",
                    ""type"": ""Value"",
                    ""id"": ""3dd37080-382e-4f90-be2e-830fd30959a0"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Hold"",
                    ""type"": ""Value"",
                    ""id"": ""ab4ddd07-ddc5-479c-9048-6f309ed6d9e4"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""a73de6bf-e60d-4d5b-9f47-e0fd88d3c60d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b96e8ff2-8b0d-4698-bc1f-9e5870555350"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Editor (PC) Controls"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Mouse Left Click"",
                    ""id"": ""b3cdc728-a4e4-43a2-9d03-981cb1345817"",
                    ""path"": ""OneModifier"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""f6832e59-9b1c-400a-83de-4044ce877b78"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Editor (PC) Controls"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""0758840b-d8e6-4de0-98cb-0ce9c5d38cf7"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Editor (PC) Controls"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""360f03e3-da34-411c-8844-cf4885d90acb"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Editor (PC) Controls"",
                    ""action"": ""Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Mouse Left Click"",
                    ""id"": ""37435942-ce12-4182-9829-5de6afcb9519"",
                    ""path"": ""OneModifier"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hold"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""709760d8-6ec9-44bb-9d3d-c56f2ef09c2e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Editor (PC) Controls"",
                    ""action"": ""Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""2ccb1d42-bc99-4dc7-96d0-76c97b7c8f75"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Editor (PC) Controls"",
                    ""action"": ""Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""93b20203-0f1c-442f-85f6-4636a2148bfe"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Editor (PC) Controls"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Game Controls"",
            ""id"": ""d1c061d0-352c-4212-9baa-899740e19415"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7469828d-9423-42fb-9517-c23289b743cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aa97c6d5-0a4b-463c-9e40-0cf92b5ccfc1"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Game Controls"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Editor (PC) Controls"",
            ""bindingGroup"": ""Editor (PC) Controls"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Game Controls"",
            ""bindingGroup"": ""Game Controls"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Mouse Controls
        m_MouseControls = asset.FindActionMap("Mouse Controls", throwIfNotFound: true);
        m_MouseControls_Press = m_MouseControls.FindAction("Press", throwIfNotFound: true);
        m_MouseControls_Hold = m_MouseControls.FindAction("Hold", throwIfNotFound: true);
        m_MouseControls_Pause = m_MouseControls.FindAction("Pause", throwIfNotFound: true);
        // Game Controls
        m_GameControls = asset.FindActionMap("Game Controls", throwIfNotFound: true);
        m_GameControls_Click = m_GameControls.FindAction("Click", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Mouse Controls
    private readonly InputActionMap m_MouseControls;
    private List<IMouseControlsActions> m_MouseControlsActionsCallbackInterfaces = new List<IMouseControlsActions>();
    private readonly InputAction m_MouseControls_Press;
    private readonly InputAction m_MouseControls_Hold;
    private readonly InputAction m_MouseControls_Pause;
    public struct MouseControlsActions
    {
        private @IA_Controls m_Wrapper;
        public MouseControlsActions(@IA_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Press => m_Wrapper.m_MouseControls_Press;
        public InputAction @Hold => m_Wrapper.m_MouseControls_Hold;
        public InputAction @Pause => m_Wrapper.m_MouseControls_Pause;
        public InputActionMap Get() { return m_Wrapper.m_MouseControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseControlsActions set) { return set.Get(); }
        public void AddCallbacks(IMouseControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_MouseControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MouseControlsActionsCallbackInterfaces.Add(instance);
            @Press.started += instance.OnPress;
            @Press.performed += instance.OnPress;
            @Press.canceled += instance.OnPress;
            @Hold.started += instance.OnHold;
            @Hold.performed += instance.OnHold;
            @Hold.canceled += instance.OnHold;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IMouseControlsActions instance)
        {
            @Press.started -= instance.OnPress;
            @Press.performed -= instance.OnPress;
            @Press.canceled -= instance.OnPress;
            @Hold.started -= instance.OnHold;
            @Hold.performed -= instance.OnHold;
            @Hold.canceled -= instance.OnHold;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IMouseControlsActions instance)
        {
            if (m_Wrapper.m_MouseControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMouseControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_MouseControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MouseControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MouseControlsActions @MouseControls => new MouseControlsActions(this);

    // Game Controls
    private readonly InputActionMap m_GameControls;
    private List<IGameControlsActions> m_GameControlsActionsCallbackInterfaces = new List<IGameControlsActions>();
    private readonly InputAction m_GameControls_Click;
    public struct GameControlsActions
    {
        private @IA_Controls m_Wrapper;
        public GameControlsActions(@IA_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_GameControls_Click;
        public InputActionMap Get() { return m_Wrapper.m_GameControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameControlsActions set) { return set.Get(); }
        public void AddCallbacks(IGameControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_GameControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameControlsActionsCallbackInterfaces.Add(instance);
            @Click.started += instance.OnClick;
            @Click.performed += instance.OnClick;
            @Click.canceled += instance.OnClick;
        }

        private void UnregisterCallbacks(IGameControlsActions instance)
        {
            @Click.started -= instance.OnClick;
            @Click.performed -= instance.OnClick;
            @Click.canceled -= instance.OnClick;
        }

        public void RemoveCallbacks(IGameControlsActions instance)
        {
            if (m_Wrapper.m_GameControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_GameControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameControlsActions @GameControls => new GameControlsActions(this);
    private int m_EditorPCControlsSchemeIndex = -1;
    public InputControlScheme EditorPCControlsScheme
    {
        get
        {
            if (m_EditorPCControlsSchemeIndex == -1) m_EditorPCControlsSchemeIndex = asset.FindControlSchemeIndex("Editor (PC) Controls");
            return asset.controlSchemes[m_EditorPCControlsSchemeIndex];
        }
    }
    private int m_GameControlsSchemeIndex = -1;
    public InputControlScheme GameControlsScheme
    {
        get
        {
            if (m_GameControlsSchemeIndex == -1) m_GameControlsSchemeIndex = asset.FindControlSchemeIndex("Game Controls");
            return asset.controlSchemes[m_GameControlsSchemeIndex];
        }
    }
    public interface IMouseControlsActions
    {
        void OnPress(InputAction.CallbackContext context);
        void OnHold(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IGameControlsActions
    {
        void OnClick(InputAction.CallbackContext context);
    }
}
