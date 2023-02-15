using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    private Canvas mainMenuCanvas;
    private Button firstSceneButton;

    private void Start()
    {
        mainMenuCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        firstSceneButton = GameObject.Find("Scene 1").GetComponent<Button>();
    }

    public void OnScene1Clicked()
    {
        SceneManager.LoadScene("Scene1");
    }
}
