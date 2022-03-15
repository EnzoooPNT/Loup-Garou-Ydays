//Nous travaillons sur unity, ici nous attribuons des secenes à nos menus

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    // TextMeshPro timer;
    float timer = 10;
    
    public void goBackToMenu() {
        SceneManager.LoadScene(0);
    }

    public void goToSettings() {
        SceneManager.LoadScene(5);
    }

    public void goToTheGame() {
        SceneManager.LoadScene(6);
    }
}
