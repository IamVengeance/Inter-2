using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroling : MonoBehaviour
{
    public Transform player;
    public GameObject bullet;
    public float speed;
    private float waitTime;
    public float startWaitTime;
    private float shootTime;
    public float startShootTime;

    public Transform[] moveSpots;
    private int randomSpot;
    public bool canShoot;

    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
    }

    void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
        canShoot = true;

        if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            canShoot = false;
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }

        }

        if(canShoot && player != null)
        {
            if (shootTime < 0)
            {
                Shoot();
                shootTime = startShootTime;
            }
            else
                shootTime -= Time.deltaTime;
        }
    }

    void Shoot()
    {
        GameObject go = Instantiate(bullet, transform.position, Quaternion.identity);
        go.GetComponent<BossShooter>().dir = player.position - transform.position;
    }

}
