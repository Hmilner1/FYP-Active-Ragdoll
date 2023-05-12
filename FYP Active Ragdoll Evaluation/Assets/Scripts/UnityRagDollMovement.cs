using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor.Rendering;
using UnityEngine;

public class UnityRagDollMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    public float speed;
  
    private void FixedUpdate()
    {
        rb.AddForce(transform.forward* speed);
    }
}
