using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform target;
    Transform self;
    public float speed;
    public float stoppingdistance;
    public float detectiondistance;
    public float distancefromplayer;
    float distancefromplayery;
    float distancefromplayerx;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").GetComponent<Transform>();
        self = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMoveToPlayer();
    }
    void EnemyMoveToPlayer()
    {
        distancefromplayerx = (self.position.x - target.position.x);
        if (distancefromplayerx <= 0)
            distancefromplayerx *= -1;
        distancefromplayery = (self.position.y - target.position.y);
        if (distancefromplayery <= 0)
            distancefromplayery *= -1;
        distancefromplayer = distancefromplayerx + distancefromplayery;
        if (distancefromplayer >= stoppingdistance && distancefromplayer <= detectiondistance)
        {
            transform.position -= ((self.position - target.position) * speed);
        }
    }
}

