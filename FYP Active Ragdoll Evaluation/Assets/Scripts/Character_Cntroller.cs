using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Cntroller : MonoBehaviour
{
    private WaterFloat floatController;

    void Start()
    {
        floatController = GameObject.Find("X Bot").GetComponent<WaterFloat>();
        floatController.enabled = false;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Water")
        {
            floatController.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Water")
        {
            floatController.enabled = false;
        }
    }
}
