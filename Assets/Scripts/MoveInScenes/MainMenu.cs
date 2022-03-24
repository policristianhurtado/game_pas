using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public string inputValue;
    
    public void EnterKickName(string nickname)
    {
        inputValue = nickname;
        Debug.Log(inputValue);
    }
    
    public void Jugar()
    {
        if (inputValue == null)
        {
            inputValue = "Unknown";
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log(inputValue);
    }
}
