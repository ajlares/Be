using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputReader : MonoBehaviour
{
    public InputAction horizontalAction;

    private void OnEnable()
    {
        horizontalAction.Enable();
    }

    private void OnDisable()
    {
        horizontalAction.Disable();
    }

    void Update()
    {
        float value = horizontalAction.ReadValue<float>();
        Debug.Log("Horizontal input: " + value); // -1, 0, or 1
    }
}
