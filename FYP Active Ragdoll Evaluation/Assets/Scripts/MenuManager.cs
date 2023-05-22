using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject UnityRagdoll;
    public GameObject RootRagdoll;
    public GameObject Control;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }

    public void OnClickControl()
    {
        UnityRagdoll.SetActive(false);
        RootRagdoll.SetActive(false);
        Control.SetActive(true);
    }

    public void OnClickUnity()
    {
        UnityRagdoll.SetActive(true);
        RootRagdoll.SetActive(false);
        Control.SetActive(false);
    }

    public void OnClickRoot()
    {
        UnityRagdoll.SetActive(false);
        RootRagdoll.SetActive(true);
        Control.SetActive(false);
    }

    public void OnClickReset()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
}
