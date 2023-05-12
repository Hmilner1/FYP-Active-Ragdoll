using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityRagDollScript : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private ConfigurableJoint joint;

    Quaternion InitalRotation;
  
    void Start()
    {
        this.joint = this.GetComponent<ConfigurableJoint>();
        this.InitalRotation = this.target.transform.localRotation;
    }

    private void FixedUpdate()
    {
        this.joint.targetRotation = CalcRotation();
    }

    private Quaternion CalcRotation()
    {
        return Quaternion.Inverse(this.target.localRotation) * this.InitalRotation;
    }
}
