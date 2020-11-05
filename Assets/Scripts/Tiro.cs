using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public Vector2 dir;
    public float speed;

    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
