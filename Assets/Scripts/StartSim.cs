using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSim : MonoBehaviour
{
    public void StartSimulation() {
        SceneManager.LoadScene(sceneName:"4110Project");
    }
}
