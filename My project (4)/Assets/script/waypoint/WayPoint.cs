using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    public Route route;
    public float speed = 2f;

    private Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = route.pointA;
        target = route.pointB;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            target,
            speed * Time.deltaTime
        );
        if (transform.position == target)
        {
            target = (target == route.pointA ) ? route.pointB : route.pointA;
        }
    }
}
