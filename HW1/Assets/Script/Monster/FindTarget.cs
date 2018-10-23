using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;



public class FindTarget : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float speed;
    Transform currentPatrolPoint;
    int currentPatrolIndex;

    public Transform target;
    public float chaseRange;

    private void Start()
    {
        currentPatrolIndex = 0;
        currentPatrolPoint = patrolPoints[currentPatrolIndex];

    }


    private void Update()
    {
        float distanceToTarget = Vector3.Distance(transform.position, target.position);
        if(distanceToTarget<chaseRange) {
            Vector3 targetDir = target.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180);

            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }

    }

}