using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PresentationMenu : MonoBehaviour
{
    public void goBackToMenu() {
        SceneManager.LoadScene(0);
    }

    public void goToCharacterMenu() {
        SceneManager.LoadScene(3);
    }

    public void goToRulesMenu() {
        SceneManager.LoadScene(4);
    }
}
