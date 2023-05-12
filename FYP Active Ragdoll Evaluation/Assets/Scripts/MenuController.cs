using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public void OnScene1Clicked()
    {
        SceneManager.LoadScene("Scene Bridge");
    }

    public void OnScene2Clicked()
    {
        SceneManager.LoadScene("Scene Terrain");
    }

    public void OnScene3Clicked()
    {
        SceneManager.LoadScene("Scene Water");
    }
}
