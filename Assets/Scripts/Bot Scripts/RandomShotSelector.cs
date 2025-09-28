using UnityEngine;

public class RandomShotSelector : IShotSelector
{
    private ShotSO[] shots;

    public RandomShotSelector(ShotSO[] shots)
    {
        this.shots = shots;
    }

    public ShotSO PickShot()
    {
        int random = Random.Range(0, shots.Length);
        return shots[random];
    }
}