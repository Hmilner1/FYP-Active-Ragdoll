using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonRagdollController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody m_Rb;

    public float speed;

    // Update is called once per frame
    void Update()
    {
        m_Rb.velocity =  new Vector3(-1, 0, 0).normalized * speed * Time.deltaTime;
    }
}
