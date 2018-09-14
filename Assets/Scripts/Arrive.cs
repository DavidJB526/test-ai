﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrive : AgentBehavior {

    public float targetRadius;
    public float slowRadius;
    public float timeToTarget = 0.1f;

    public override Steering GetSteering()
    {
        //speed based on distance to target
        Steering steering = new Steering();
        Vector3 direction = target.transform.position - transform.position;
        float distance = direction.magnitude;
        float targetSpeed;
        if (distance < targetRadius)
            return steering;
        if (distance > slowRadius)
            targetSpeed = agent.maxSpeed;
        else
            targetSpeed = agent.maxSpeed * distance / slowRadius;
        //Stopped at Page 10, Step 3

        return base.GetSteering();
    }
}
