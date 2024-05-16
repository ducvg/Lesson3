using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    public Vector3[] moveTargetOrder;
    private int i = 0;
    private Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = moveTargetOrder[0];
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if((transform.position - target).magnitude ==0) {
            target = moveTargetOrder[i];
            if (i == 3) i = 0;
            else i++;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        transform.LookAt(target);
    }
}
