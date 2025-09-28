using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    public Vector3 MoveVector { get; private set; }
    public bool IsHitting { get; private set; }

    void Update()
    {
        // Movimiento
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        MoveVector = new Vector3(h, 0, v).normalized;

        if (Input.GetKey(KeyCode.Space))
        {
            IsHitting = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            IsHitting = false;
        }
    }
}
