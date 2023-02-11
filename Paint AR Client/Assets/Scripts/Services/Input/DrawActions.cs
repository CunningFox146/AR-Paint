//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Input/DrawActions.inputactions
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

namespace ArPaint.Input
{
    public partial class @DrawActions : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @DrawActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""DrawActions"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""8cf2aa07-123e-4be0-af35-43f7c8f99993"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""c82afefe-0221-4066-a6f1-15ce6ecbb69a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ClickPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1428aea9-62d7-4a1b-8899-bcaec35528d1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f00deab0-4c64-4358-a717-8a4c55f6fa38"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99b046b3-5e39-40f9-bddb-45de902eda7d"",
                    ""path"": ""<Touchscreen>/touch*/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""855d96dc-9fe0-4d67-8744-3b686bb1bdc3"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClickPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""986aaa08-ac2e-4d0b-aedc-d5e3ea116850"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClickPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Touch
            m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
            m_Touch_Click = m_Touch.FindAction("Click", throwIfNotFound: true);
            m_Touch_ClickPosition = m_Touch.FindAction("ClickPosition", throwIfNotFound: true);
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

        // Touch
        private readonly InputActionMap m_Touch;
        private ITouchActions m_TouchActionsCallbackInterface;
        private readonly InputAction m_Touch_Click;
        private readonly InputAction m_Touch_ClickPosition;
        public struct TouchActions
        {
            private @DrawActions m_Wrapper;
            public TouchActions(@DrawActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Click => m_Wrapper.m_Touch_Click;
            public InputAction @ClickPosition => m_Wrapper.m_Touch_ClickPosition;
            public InputActionMap Get() { return m_Wrapper.m_Touch; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
            public void SetCallbacks(ITouchActions instance)
            {
                if (m_Wrapper.m_TouchActionsCallbackInterface != null)
                {
                    @Click.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnClick;
                    @Click.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnClick;
                    @Click.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnClick;
                    @ClickPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnClickPosition;
                    @ClickPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnClickPosition;
                    @ClickPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnClickPosition;
                }
                m_Wrapper.m_TouchActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Click.started += instance.OnClick;
                    @Click.performed += instance.OnClick;
                    @Click.canceled += instance.OnClick;
                    @ClickPosition.started += instance.OnClickPosition;
                    @ClickPosition.performed += instance.OnClickPosition;
                    @ClickPosition.canceled += instance.OnClickPosition;
                }
            }
        }
        public TouchActions @Touch => new TouchActions(this);
        public interface ITouchActions
        {
            void OnClick(InputAction.CallbackContext context);
            void OnClickPosition(InputAction.CallbackContext context);
        }
    }
}