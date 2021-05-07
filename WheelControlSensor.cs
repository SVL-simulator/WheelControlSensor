/**
 * Copyright (c) 2019-2021 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using UnityEngine;
using Simulator.Bridge;
using Simulator.Utilities;
using Simulator.Sensors.UI;
using System.Collections.Generic;

namespace Simulator.Sensors
{
    [SensorType("Wheel Control", new System.Type[] { })]
    public class WheelControlSensor : SensorBase, IVehicleInputs
    {
        public float SteerInput { get; private set; } = 0f;
        public float AccelInput { get; private set; } = 0f;
        public float BrakeInput { get; private set; } = 0f;
        private float steer = 0f;
        private float accel = 0f;
        private float brake = 0f;

        [AnalysisMeasurement(MeasurementType.Input)]
        public float MaxSteer = 0f;
        [AnalysisMeasurement(MeasurementType.Input)]
        public float MaxAccel = 0f;
        [AnalysisMeasurement(MeasurementType.Input)]
        public float MaxBrake = 0f;

        private SimulatorControls Controls;
        private IVehicleDynamics Dynamics;
        private VehicleActions Actions;
        private IAgentController Controller;

        private OperatingSystemFamily operatingSystemFamily;

        private void Awake()
        {
            operatingSystemFamily = SystemInfo.operatingSystemFamily;
        }

        private void Start()
        {
            Controller = GetComponentInParent<IAgentController>();
            Dynamics = GetComponentInParent<IVehicleDynamics>();
            Actions = GetComponentInParent<VehicleActions>();

            Debug.Assert(Dynamics != null);
            Debug.Assert(Actions != null);
            Debug.Assert(SimulatorManager.Instance != null);

            Controls = SimulatorManager.Instance.controls;
            Controls.VehicleWheel.Accel.performed += AccelPerformed;
            Controls.VehicleWheel.Accel.canceled += AccelCanceled;
            Controls.VehicleWheel.Brake.performed += BrakePerformed;
            Controls.VehicleWheel.Brake.canceled += BrakeCanceled;
            Controls.VehicleWheel.Steer.performed += SteerPerformed;
            Controls.VehicleWheel.ButtonA.performed += ButtonA;
            Controls.VehicleWheel.ButtonB.performed += ButtonB;
            Controls.VehicleWheel.ButtonX.performed += ButtonX;
            Controls.VehicleWheel.ButtonY.performed += ButtonY;
            Controls.VehicleWheel.ButtonRB.performed += ButtonRB;
            Controls.VehicleWheel.ButtonLB.performed += ButtonLB;
            Controls.VehicleWheel.ButtonSelect.performed += ButtonSelect;
            Controls.VehicleWheel.ButtonStart.performed += ButtonStart;
            Controls.VehicleWheel.ButtonRSB.performed += ButtonRSB;
            Controls.VehicleWheel.ButtonLSB.performed += ButtonLSB;
            Controls.VehicleWheel.ButtonCenter.performed += ButtonCenter;
            Controls.VehicleWheel.DPad.performed += DPad;
        }

        private void AccelPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            switch (operatingSystemFamily)
            {
                case OperatingSystemFamily.Other:
                    break;
                case OperatingSystemFamily.MacOSX:
                    break;
                case OperatingSystemFamily.Windows:
                    //accel = Mathf.InverseLerp(1f, -1f, obj.ReadValue<float>());
                    accel = Mathf.InverseLerp(-1f, 1f, obj.ReadValue<float>());
                    break;
                case OperatingSystemFamily.Linux:
                    accel = Mathf.InverseLerp(-1f, 1f, obj.ReadValue<float>());
                    break;
                default:
                    break;
            }
        }

        private void AccelCanceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            accel = 0f;
        }

        private void BrakePerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            brake = Mathf.InverseLerp(1f, -1f, obj.ReadValue<float>());
        }

        private void BrakeCanceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            brake = 0f;
        }

        private void SteerPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            steer = obj.ReadValue<float>();
        }

        private void ButtonA(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            SimulatorManager.Instance?.AgentManager?.SetNextCurrentActiveAgent();
        }

        private void ButtonB(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            SimulatorManager.Instance?.NPCManager?.ToggleNPC();
        }

        private void ButtonX(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            SimulatorManager.Instance?.UIManager?.ToggleVisualizers();
        }

        private void ButtonY(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            SimulatorManager.Instance?.CameraManager?.ToggleCameraState();
        }

        private void ButtonRB(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            accel = obj.ReadValue<float>();
        }

        private void ButtonLB(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            brake = obj.ReadValue<float>();
        }

        private void ButtonSelect(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            SimulatorManager.Instance?.UIManager?.MenuButtonOnClick();
        }

        private void ButtonStart(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            SimulatorManager.Instance?.UIManager?.PauseButtonOnClick();
        }

        private void ButtonRSB(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            Actions.IncrementHeadLightState();
        }

        private void ButtonLSB(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (!Controller.Active)
                return;

            Dynamics.ToggleReverse();
        }

        private void ButtonCenter(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            Actions.InteriorLight = !Actions.InteriorLight;
        }

        private void DPad(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            var dpad = obj.ReadValue<Vector2>();
            if (dpad.y == 1) // up
            {
                //
            }
            else if (dpad.y == -1) // down
            {
                //
            }
            else if (dpad.x == 1) // right
            {
                //
            }
            else if (dpad.x == -1) // left
            {
                //
            }
        }

        private void Update()
        {
            if (Controller.Active)
            {
                SteerInput = steer;
                AccelInput = accel - brake;
                BrakeInput = brake;
                MaxSteer = Mathf.Max(MaxSteer, Mathf.Sign(steer) * steer);
                MaxAccel = Mathf.Max(MaxAccel, Mathf.Sign(accel) * accel);
                MaxBrake = Mathf.Max(MaxBrake, Mathf.Sign(brake) * brake);
            }
        }

        private void OnDestroy()
        {
            Controls.VehicleWheel.Accel.performed -= AccelPerformed;
            Controls.VehicleWheel.Accel.canceled -= AccelCanceled;
            Controls.VehicleWheel.Brake.performed -= BrakePerformed;
            Controls.VehicleWheel.Brake.canceled -= BrakeCanceled;
            Controls.VehicleWheel.Steer.performed -= SteerPerformed;
            Controls.VehicleWheel.ButtonA.performed -= ButtonA;
            Controls.VehicleWheel.ButtonB.performed -= ButtonB;
            Controls.VehicleWheel.ButtonX.performed -= ButtonX;
            Controls.VehicleWheel.ButtonY.performed -= ButtonY;
            Controls.VehicleWheel.ButtonRB.performed -= ButtonRB;
            Controls.VehicleWheel.ButtonLB.performed -= ButtonLB;
            Controls.VehicleWheel.ButtonSelect.performed -= ButtonSelect;
            Controls.VehicleWheel.ButtonStart.performed -= ButtonStart;
            Controls.VehicleWheel.ButtonRSB.performed -= ButtonRSB;
            Controls.VehicleWheel.ButtonLSB.performed -= ButtonLSB;
            Controls.VehicleWheel.ButtonCenter.performed -= ButtonCenter;
            Controls.VehicleWheel.DPad.performed -= DPad;
        }

        public override void OnBridgeSetup(BridgeInstance bridge)
        {
            //
        }

        public override void OnVisualize(Visualizer visualizer)
        {
            Debug.Assert(visualizer != null);
            var graphData = new Dictionary<string, object>()
            {
                {"Accel", accel},
                {"Steer", steer},
                {"Brake", brake},
                {"Speed", Dynamics.Velocity.magnitude},
                {"Hand Brake", Dynamics.HandBrake},
                {"Ignition", Dynamics.CurrentIgnitionStatus},
                {"Reverse", Dynamics.Reverse},
                {"Gear", Dynamics.CurrentGear},
                {"RPM", Dynamics.CurrentRPM},
                {"Velocity", Dynamics.Velocity}
            };
            visualizer.UpdateGraphValues(graphData);
        }

        public override void OnVisualizeToggle(bool state)
        {
            //
        }
    }
}
