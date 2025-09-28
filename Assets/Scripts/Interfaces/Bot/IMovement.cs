using UnityEngine;

public interface IMovement
{
    void MoveTowardsBall(Transform bot, Transform ball, float speed);
}