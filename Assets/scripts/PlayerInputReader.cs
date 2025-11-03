using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputReader : MonoBehaviour
{
    public InputSystem_Actions Actions;

    private void Start()
    {
        Actions = new InputSystem_Actions();
    }

    void Update()
    {
        float value = Actions.Control.Rotate.ReadValue<float>();
        Debug.Log("Horizontal input: " + value); // -1, 0, or 1
    }

    public void Rotation()
    {
        
    }
}
