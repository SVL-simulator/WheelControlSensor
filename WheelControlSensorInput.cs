// GENERATED AUTOMATICALLY FROM 'Assets/External/Sensors/WheelControlSensor/WheelControlSensorInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @WheelControlSensorInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @WheelControlSensorInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""WheelControlSensorInput"",
    ""maps"": [
        {
            ""name"": ""VehicleWheel"",
            ""id"": ""037577cd-9d0e-462a-937f-029d6de72d02"",
            ""actions"": [
                {
                    ""name"": ""Accel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""888616c7-579c-4efd-8527-708e683af1eb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steer"",
                    ""type"": ""PassThrough"",
                    ""id"": ""455577db-93bb-4060-849b-d5608bfb6bad"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""PassThrough"",
                    ""id"": ""27a09f05-a77b-4209-b710-af353ec2bc76"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonA"",
                    ""type"": ""PassThrough"",
                    ""id"": ""59312a63-d87f-4991-a404-426b8dfcaa04"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonB"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7f46a0eb-0050-49d4-bd15-dd187a4ff30c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f8c5c1e7-bfad-48f3-a844-2bda89c29c45"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c4f8a72b-afe3-448d-896c-4b366b62b997"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonRB"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c22f26a3-873d-4afe-9085-8b3fd32fff3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonLB"",
                    ""type"": ""PassThrough"",
                    ""id"": ""37d85537-6481-4742-864c-c36a343fb6c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonStart"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e384c3ab-2f9b-4e19-b583-3c653f088a80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonSelect"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ae7c3ac6-1379-4238-a41f-fc9091edc2fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonRSB"",
                    ""type"": ""PassThrough"",
                    ""id"": ""83e310ca-be8a-4d82-a1ea-1dbc08131851"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonLSB"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f948e86f-4ed4-48ef-9772-f5e5fac8ec37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonCenter"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9d981352-e4c1-4fd7-b199-8e339f31d4d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DPad"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1470b2f1-7873-4929-926b-fc30937dea0a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bed5fb37-63ac-4233-850e-a9e14a6a203b"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/stick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e46b7fbe-610e-4421-a188-f631133056e7"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Stick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9556cee8-daea-4154-b0b5-39cf87329e20"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/stick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f564dea-9879-4600-99be-7b33abf9d05b"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Stick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62d31aaa-3ef4-44f1-aa07-65401643ca96"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c4a7659-7989-4829-a2bb-b6067a77b358"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9ddbe73-def5-4e00-afd9-9cd54179ac5d"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/trigger"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonA"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8537f36d-f294-4103-b2a1-825657ad8c1b"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Trigger"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonA"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4dbfa0de-c0e9-4235-b1cb-179f8f54ce88"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button2"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc976bf4-0745-4116-98d3-e2a76713a068"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Thumb"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12cddf58-a50f-4b3c-bd49-1dd09dc4bc5a"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button3"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8140ae56-83bc-43c4-91b3-72c738a65e42"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Thumb2"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c48d30f-d4b7-4918-83fc-d141309b1bff"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button4"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9378683b-1749-48e6-bf91-f42543a61ff6"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Top"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3428280-2044-4494-a71d-8876ccc378db"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonRB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""636e0b69-3e2b-4879-91c6-00b1161766cd"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Top2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonRB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc92cf1c-2647-4b2e-99c4-2ef7883f4dcb"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonLB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da0c14b8-1c5d-4d3b-8fcc-0676a90e32d3"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Pinkie"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonLB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1fbb4a0-cd63-4a72-84bc-e27bb2fa6387"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button7"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2257a097-7d75-48ca-a15c-3a673a3b8e63"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Base"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""978313b2-9e48-4479-ae0c-defb6a04acfa"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button8"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0272537-424d-431c-8333-30bb462c1db5"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Base2"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""533f135e-d206-4e92-8448-e104dcceedc8"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button9"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonRSB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e65f0c6-ca81-425c-8c8c-ea4970967ee7"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Base3"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonRSB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8b5f0be-5ae7-4af0-a08c-8750cd61b429"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button10"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonLSB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d82b876-f25b-460d-b0cf-6e937ef9676e"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Base4"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonLSB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5084feaa-62d9-47db-995c-a8c3b28ef2ca"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/button11"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonCenter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6119989e-a435-4d18-b3c3-c05bbb1b6448"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Base5"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonCenter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b4a74245-fb08-41e8-ad8d-1f61857d5d8f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a7325f94-c632-413e-9e47-dee272324d3c"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/hat/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6f2aeda4-1b33-4970-9d5f-3c7211868a15"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/hat/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a4e08757-fc90-4c4e-a67c-d3ef308650e6"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/hat/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d3c50b20-52f4-47b2-96f4-edb5cbee34a9"",
                    ""path"": ""<HID::Logitech G920 Driving Force Racing Wheel for Xbox One>/hat/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c17d2f10-b018-407f-be1e-dc7e4203aaff"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9fd13902-02a1-48c7-a622-65ddacfacc3e"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Hat/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2a0446a0-646f-4b32-9693-7c30637ea4eb"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Hat/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cb91eeab-35ac-41dc-8d2f-34195b8a5310"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Hat/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f2f38962-9b2c-406c-bf86-e4a31a582614"",
                    ""path"": ""<Linux::LogitechInc::LogitechG920DrivingForceRacingWheel>/Hat/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // VehicleWheel
        m_VehicleWheel = asset.FindActionMap("VehicleWheel", throwIfNotFound: true);
        m_VehicleWheel_Accel = m_VehicleWheel.FindAction("Accel", throwIfNotFound: true);
        m_VehicleWheel_Steer = m_VehicleWheel.FindAction("Steer", throwIfNotFound: true);
        m_VehicleWheel_Brake = m_VehicleWheel.FindAction("Brake", throwIfNotFound: true);
        m_VehicleWheel_ButtonA = m_VehicleWheel.FindAction("ButtonA", throwIfNotFound: true);
        m_VehicleWheel_ButtonB = m_VehicleWheel.FindAction("ButtonB", throwIfNotFound: true);
        m_VehicleWheel_ButtonX = m_VehicleWheel.FindAction("ButtonX", throwIfNotFound: true);
        m_VehicleWheel_ButtonY = m_VehicleWheel.FindAction("ButtonY", throwIfNotFound: true);
        m_VehicleWheel_ButtonRB = m_VehicleWheel.FindAction("ButtonRB", throwIfNotFound: true);
        m_VehicleWheel_ButtonLB = m_VehicleWheel.FindAction("ButtonLB", throwIfNotFound: true);
        m_VehicleWheel_ButtonStart = m_VehicleWheel.FindAction("ButtonStart", throwIfNotFound: true);
        m_VehicleWheel_ButtonSelect = m_VehicleWheel.FindAction("ButtonSelect", throwIfNotFound: true);
        m_VehicleWheel_ButtonRSB = m_VehicleWheel.FindAction("ButtonRSB", throwIfNotFound: true);
        m_VehicleWheel_ButtonLSB = m_VehicleWheel.FindAction("ButtonLSB", throwIfNotFound: true);
        m_VehicleWheel_ButtonCenter = m_VehicleWheel.FindAction("ButtonCenter", throwIfNotFound: true);
        m_VehicleWheel_DPad = m_VehicleWheel.FindAction("DPad", throwIfNotFound: true);
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

    // VehicleWheel
    private readonly InputActionMap m_VehicleWheel;
    private IVehicleWheelActions m_VehicleWheelActionsCallbackInterface;
    private readonly InputAction m_VehicleWheel_Accel;
    private readonly InputAction m_VehicleWheel_Steer;
    private readonly InputAction m_VehicleWheel_Brake;
    private readonly InputAction m_VehicleWheel_ButtonA;
    private readonly InputAction m_VehicleWheel_ButtonB;
    private readonly InputAction m_VehicleWheel_ButtonX;
    private readonly InputAction m_VehicleWheel_ButtonY;
    private readonly InputAction m_VehicleWheel_ButtonRB;
    private readonly InputAction m_VehicleWheel_ButtonLB;
    private readonly InputAction m_VehicleWheel_ButtonStart;
    private readonly InputAction m_VehicleWheel_ButtonSelect;
    private readonly InputAction m_VehicleWheel_ButtonRSB;
    private readonly InputAction m_VehicleWheel_ButtonLSB;
    private readonly InputAction m_VehicleWheel_ButtonCenter;
    private readonly InputAction m_VehicleWheel_DPad;
    public struct VehicleWheelActions
    {
        private @WheelControlSensorInput m_Wrapper;
        public VehicleWheelActions(@WheelControlSensorInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accel => m_Wrapper.m_VehicleWheel_Accel;
        public InputAction @Steer => m_Wrapper.m_VehicleWheel_Steer;
        public InputAction @Brake => m_Wrapper.m_VehicleWheel_Brake;
        public InputAction @ButtonA => m_Wrapper.m_VehicleWheel_ButtonA;
        public InputAction @ButtonB => m_Wrapper.m_VehicleWheel_ButtonB;
        public InputAction @ButtonX => m_Wrapper.m_VehicleWheel_ButtonX;
        public InputAction @ButtonY => m_Wrapper.m_VehicleWheel_ButtonY;
        public InputAction @ButtonRB => m_Wrapper.m_VehicleWheel_ButtonRB;
        public InputAction @ButtonLB => m_Wrapper.m_VehicleWheel_ButtonLB;
        public InputAction @ButtonStart => m_Wrapper.m_VehicleWheel_ButtonStart;
        public InputAction @ButtonSelect => m_Wrapper.m_VehicleWheel_ButtonSelect;
        public InputAction @ButtonRSB => m_Wrapper.m_VehicleWheel_ButtonRSB;
        public InputAction @ButtonLSB => m_Wrapper.m_VehicleWheel_ButtonLSB;
        public InputAction @ButtonCenter => m_Wrapper.m_VehicleWheel_ButtonCenter;
        public InputAction @DPad => m_Wrapper.m_VehicleWheel_DPad;
        public InputActionMap Get() { return m_Wrapper.m_VehicleWheel; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleWheelActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleWheelActions instance)
        {
            if (m_Wrapper.m_VehicleWheelActionsCallbackInterface != null)
            {
                @Accel.started -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnAccel;
                @Accel.performed -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnAccel;
                @Accel.canceled -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnAccel;
                @Steer.started -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnSteer;
                @Steer.performed -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnSteer;
                @Steer.canceled -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnSteer;
                @Brake.started -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnBrake;
                @ButtonA.started -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonA;
                @ButtonA.performed -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonA;
                @ButtonA.canceled -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonA;
                @ButtonB.started -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonB;
                @ButtonB.performed -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonB;
                @ButtonB.canceled -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonB;
                @ButtonX.started -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonX;
                @ButtonX.performed -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonX;
                @ButtonX.canceled -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonX;
                @ButtonY.started -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonY;
                @ButtonY.performed -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonY;
                @ButtonY.canceled -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonY;
                @ButtonRB.started -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonRB;
                @ButtonRB.performed -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonRB;
                @ButtonRB.canceled -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonRB;
                @ButtonLB.started -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonLB;
                @ButtonLB.performed -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonLB;
                @ButtonLB.canceled -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonLB;
                @ButtonStart.started -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonStart;
                @ButtonStart.performed -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonStart;
                @ButtonStart.canceled -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonStart;
                @ButtonSelect.started -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonSelect;
                @ButtonSelect.performed -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonSelect;
                @ButtonSelect.canceled -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonSelect;
                @ButtonRSB.started -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonRSB;
                @ButtonRSB.performed -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonRSB;
                @ButtonRSB.canceled -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonRSB;
                @ButtonLSB.started -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonLSB;
                @ButtonLSB.performed -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonLSB;
                @ButtonLSB.canceled -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonLSB;
                @ButtonCenter.started -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonCenter;
                @ButtonCenter.performed -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonCenter;
                @ButtonCenter.canceled -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnButtonCenter;
                @DPad.started -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnDPad;
                @DPad.performed -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnDPad;
                @DPad.canceled -= m_Wrapper.m_VehicleWheelActionsCallbackInterface.OnDPad;
            }
            m_Wrapper.m_VehicleWheelActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accel.started += instance.OnAccel;
                @Accel.performed += instance.OnAccel;
                @Accel.canceled += instance.OnAccel;
                @Steer.started += instance.OnSteer;
                @Steer.performed += instance.OnSteer;
                @Steer.canceled += instance.OnSteer;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @ButtonA.started += instance.OnButtonA;
                @ButtonA.performed += instance.OnButtonA;
                @ButtonA.canceled += instance.OnButtonA;
                @ButtonB.started += instance.OnButtonB;
                @ButtonB.performed += instance.OnButtonB;
                @ButtonB.canceled += instance.OnButtonB;
                @ButtonX.started += instance.OnButtonX;
                @ButtonX.performed += instance.OnButtonX;
                @ButtonX.canceled += instance.OnButtonX;
                @ButtonY.started += instance.OnButtonY;
                @ButtonY.performed += instance.OnButtonY;
                @ButtonY.canceled += instance.OnButtonY;
                @ButtonRB.started += instance.OnButtonRB;
                @ButtonRB.performed += instance.OnButtonRB;
                @ButtonRB.canceled += instance.OnButtonRB;
                @ButtonLB.started += instance.OnButtonLB;
                @ButtonLB.performed += instance.OnButtonLB;
                @ButtonLB.canceled += instance.OnButtonLB;
                @ButtonStart.started += instance.OnButtonStart;
                @ButtonStart.performed += instance.OnButtonStart;
                @ButtonStart.canceled += instance.OnButtonStart;
                @ButtonSelect.started += instance.OnButtonSelect;
                @ButtonSelect.performed += instance.OnButtonSelect;
                @ButtonSelect.canceled += instance.OnButtonSelect;
                @ButtonRSB.started += instance.OnButtonRSB;
                @ButtonRSB.performed += instance.OnButtonRSB;
                @ButtonRSB.canceled += instance.OnButtonRSB;
                @ButtonLSB.started += instance.OnButtonLSB;
                @ButtonLSB.performed += instance.OnButtonLSB;
                @ButtonLSB.canceled += instance.OnButtonLSB;
                @ButtonCenter.started += instance.OnButtonCenter;
                @ButtonCenter.performed += instance.OnButtonCenter;
                @ButtonCenter.canceled += instance.OnButtonCenter;
                @DPad.started += instance.OnDPad;
                @DPad.performed += instance.OnDPad;
                @DPad.canceled += instance.OnDPad;
            }
        }
    }
    public VehicleWheelActions @VehicleWheel => new VehicleWheelActions(this);
    public interface IVehicleWheelActions
    {
        void OnAccel(InputAction.CallbackContext context);
        void OnSteer(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnButtonA(InputAction.CallbackContext context);
        void OnButtonB(InputAction.CallbackContext context);
        void OnButtonX(InputAction.CallbackContext context);
        void OnButtonY(InputAction.CallbackContext context);
        void OnButtonRB(InputAction.CallbackContext context);
        void OnButtonLB(InputAction.CallbackContext context);
        void OnButtonStart(InputAction.CallbackContext context);
        void OnButtonSelect(InputAction.CallbackContext context);
        void OnButtonRSB(InputAction.CallbackContext context);
        void OnButtonLSB(InputAction.CallbackContext context);
        void OnButtonCenter(InputAction.CallbackContext context);
        void OnDPad(InputAction.CallbackContext context);
    }
}
