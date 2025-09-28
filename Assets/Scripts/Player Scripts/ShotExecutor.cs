using UnityEngine;

public class ShotExecutor : MonoBehaviour
{
    [SerializeField] private ShotManager shotManager;
    [SerializeField] private Transform ball;

    //public Shot CurrentShot { get; private set; }

    private void Start()
    {
        //CurrentShot = shotManager.topSpin; // Por defecto
    }

    //public void SelectShot(ShotType type)
    //{
    //    switch (type)
    //    {
    //        case ShotType.TopSpin: CurrentShot = shotManager.topSpin; break;
    //        case ShotType.Flat: CurrentShot = shotManager.flat; break;
    //        case ShotType.FlatServe: CurrentShot = shotManager.flatServe; break;
    //        case ShotType.KickServe: CurrentShot = shotManager.kickServe; break;
    //    }
    //}

    //public void ExecuteShot(Collider ballCollider, Vector3 aimTarget, Transform playerTransform)
    //{
    //    Rigidbody rb = ballCollider.GetComponent<Rigidbody>();
    //    Vector3 dir = aimTarget - playerTransform.position;

    //    rb.velocity = dir.normalized * CurrentShot.hitForce + new Vector3(0, CurrentShot.upForce, 0);

    //    Ball ballScript = ballCollider.GetComponent<Ball>();
    //    ballScript.hitter = Hitter.Player;
    //}
}
