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
    // Start is called before the first frame update
    void Start()
    {
        this.joint = this.GetComponent<ConfigurableJoint>();
        this.InitalRotation = this.target.transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
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
