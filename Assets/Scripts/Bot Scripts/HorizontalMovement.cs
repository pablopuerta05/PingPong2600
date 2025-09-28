using UnityEngine;

public class HorizontalMovement : IMovement
{
    public void MoveTowardsBall(Transform bot, Transform ball, float speed)
    {
        Vector3 target = bot.position;
        target.x = ball.position.x;
        bot.position = Vector3.MoveTowards(bot.position, target, speed * Time.deltaTime);
    }
}