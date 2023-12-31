#if ENABLE_OPENXR

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Packages/com.interhaptics.core_sdk/Runtime/Platforms/OpenXR/IH_HapticsInput.inputactions
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

public partial class @IH_HapticsInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @IH_HapticsInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""IH_HapticsInput"",
    ""maps"": [
        {
            ""name"": ""HapticsXR"",
            ""id"": ""cb5a2207-7e84-46e3-8f8d-38e5b312def6"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""type"": ""Value"",
                    ""id"": ""98e14162-25d0-4640-89ae-c88f70e3e340"",
                    ""expectedControlType"": ""Haptic"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Value"",
                    ""id"": ""2f219f26-2872-45ef-9133-636d833ebcf6"",
                    ""expectedControlType"": ""Haptic"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""07120713-2f08-4c23-af73-308fb7393ccd"",
                    ""path"": ""<XRController>{LeftHand}/haptic"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21259124-14f0-4518-8ef2-52289145b374"",
                    ""path"": ""<XRController>{RightHand}/haptic"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // HapticsXR
        m_HapticsXR = asset.FindActionMap("HapticsXR", throwIfNotFound: true);
        m_HapticsXR_Left = m_HapticsXR.FindAction("Left", throwIfNotFound: true);
        m_HapticsXR_Right = m_HapticsXR.FindAction("Right", throwIfNotFound: true);
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

    // HapticsXR
    private readonly InputActionMap m_HapticsXR;
    private IHapticsXRActions m_HapticsXRActionsCallbackInterface;
    private readonly InputAction m_HapticsXR_Left;
    private readonly InputAction m_HapticsXR_Right;
    public struct HapticsXRActions
    {
        private @IH_HapticsInput m_Wrapper;
        public HapticsXRActions(@IH_HapticsInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left => m_Wrapper.m_HapticsXR_Left;
        public InputAction @Right => m_Wrapper.m_HapticsXR_Right;
        public InputActionMap Get() { return m_Wrapper.m_HapticsXR; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HapticsXRActions set) { return set.Get(); }
        public void SetCallbacks(IHapticsXRActions instance)
        {
            if (m_Wrapper.m_HapticsXRActionsCallbackInterface != null)
            {
                @Left.started -= m_Wrapper.m_HapticsXRActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_HapticsXRActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_HapticsXRActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_HapticsXRActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_HapticsXRActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_HapticsXRActionsCallbackInterface.OnRight;
            }
            m_Wrapper.m_HapticsXRActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
            }
        }
    }
    public HapticsXRActions @HapticsXR => new HapticsXRActions(this);
    public interface IHapticsXRActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
    }
}
#endif