using UnityEngine;

[CreateAssetMenu(menuName = "PingPong2600/Shot")]
public class ShotSO : ScriptableObject
{
    public string shotName;
    public float hitForce;
    public float upForce;

    public virtual void ApplyForce(Rigidbody rb, Vector3 direction)
    {
        rb.velocity = direction.normalized * hitForce + new Vector3(0, upForce, 0);
    }
}