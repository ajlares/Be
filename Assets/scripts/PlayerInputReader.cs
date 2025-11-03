using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInputReader : MonoBehaviour
{
    public InputSystem_Actions Actions;
    public float Direction;
    
    public static PlayerInputReader Instance;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        Actions = new InputSystem_Actions();
    }

    private void Update()
    {
        if (UnityEngine.InputSystem.Gyroscope.current != null)
        {
            Vector3 rotationRate = UnityEngine.InputSystem.Gyroscope.current.angularVelocity.ReadValue();
            if (rotationRate.y > 0.5f)
            {
                Direction = 1;
            }
            else if (rotationRate.y < -0.5f)
            {
                Direction = -1;
            }
            else
            {
                Direction = 0;
            }
        }
    }
    public void Rotation(InputAction.CallbackContext  context)
    {
        //Direction = context.ReadValue<float>();
    }
    public void Touch(InputAction.CallbackContext context)
    { 
        if (context.phase == InputActionPhase.Started)
        {
            mapManager.Instance.FlipMap();
        }
    }
}