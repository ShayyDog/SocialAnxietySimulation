using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMain : MonoBehaviour
{
    public void ExitToMainMenu() {
        SceneManager.LoadScene(sceneName:"MainMenu");
    }
}
