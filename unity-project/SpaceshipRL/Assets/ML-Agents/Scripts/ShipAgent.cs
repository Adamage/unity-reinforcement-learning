using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShipAgent : Agent
{
    public Rigidbody rigidBody;
    public GameObject agentObject;

    public  void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(1, 1, 1);

    }


    public override void AgentOnDone()
    {
        base.AgentOnDone();
    }

    public override void AgentReset()
    {
        base.AgentReset();
    }

    public override void AgentStep(float[] action)
    {
        base.AgentStep(action);
    }

    public override List<float> CollectState()
    {
        return base.CollectState();
    }

    public override void InitializeAgent()
    {
        base.InitializeAgent();
    }
}
