using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetOrientation : MonoBehaviour
{
    public Transform target;
    public ObjectShooter[] shooters;

    void Update()
    {
        if(target.position.x > transform.position.x)
            TurnRight();
        else
            TurnLeft();
    }

    void TurnRight()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);

        foreach(ObjectShooter objShooter in shooters)
        {
            objShooter.shootDirection = new Vector2(1, objShooter.shootDirection.y);
        }
    }

    void TurnLeft()
    {
        transform.rotation = Quaternion.Euler(0, 180, 0);

        foreach (ObjectShooter objShooter in shooters)
        {
            objShooter.shootDirection = new Vector2(-1, objShooter.shootDirection.y);
        }
    }
}
