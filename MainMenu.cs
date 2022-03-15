using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour

{
    // Fonction qui emmène l'utilisateur à la scène 1
    public void goToPlayMenu() {
        SceneManager.LoadScene(1);
    }

    
    
    // Fonction qui emmène l'utilisateur à la scène 2
    public void goToRulesMenu() {
        SceneManager.LoadScene(2);
    }

    // Fonction qui quitte l'application
    public void quitMenu() {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
