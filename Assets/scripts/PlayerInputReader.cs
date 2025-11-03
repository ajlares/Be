using System;
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
    public void Rotation(InputAction.CallbackContext  context)
    {
        Direction = context.ReadValue<float>();
    }
}