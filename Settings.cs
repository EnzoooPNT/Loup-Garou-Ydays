using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public void goBackToMenu() {
        SceneManager.LoadScene(1);
    }
}
