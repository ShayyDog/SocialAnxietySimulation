using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToCMenu : MonoBehaviour
{
    public void StartCMenu() {
        SceneManager.LoadScene(sceneName:"CopingMenu");
    }
}
