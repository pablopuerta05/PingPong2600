using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;

    public void Move(Vector3 direction)
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
}
