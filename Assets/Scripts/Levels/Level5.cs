using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level5 : MonoBehaviour
{
    private LoadSceneManager loadSceneManager;

    private void Start()
    {
        loadSceneManager = GameObject.FindGameObjectWithTag("SceneLoad").GetComponent<LoadSceneManager>();
        Debug.Log(PlayerPrefs.GetString("nickname", "unknow"));
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            loadSceneManager.LoadNextScene(3); //LoadNextScene();
        }
    }
}
