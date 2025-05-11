using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CarControl))]
public class InputManager : MonoBehaviour
{
    private CarControl carControl;

    private void Start()
    {
        carControl = GetComponent<CarControl>();
    }

    public void OnSteer(InputAction.CallbackContext callbackContext)
    {
        carControl.Steer = callbackContext.phase switch
        {
            InputActionPhase.Started or InputActionPhase.Performed => callbackContext.ReadValue<float>(),
            InputActionPhase.Disabled or InputActionPhase.Waiting or InputActionPhase.Canceled or _ => 0,
        };
    }

    public void OnAccelerate(InputAction.CallbackContext callbackContext)
    {
        carControl.Accelerate = callbackContext.phase switch
        {
            InputActionPhase.Started or InputActionPhase.Performed => callbackContext.ReadValue<float>(),
            InputActionPhase.Disabled or InputActionPhase.Waiting or InputActionPhase.Canceled or _ => 0,
        };
    }

    public void OnDecelerate(InputAction.CallbackContext callbackContext)
    {
        carControl.Decelerate = callbackContext.phase switch
        {
            InputActionPhase.Started or InputActionPhase.Performed => callbackContext.ReadValue<float>(),
            InputActionPhase.Disabled or InputActionPhase.Waiting or InputActionPhase.Canceled or _ => 0,
        };
    }
}
