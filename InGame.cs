//nous sommes dans la partie, elle contient le choix aléatoire d'un personnage ainsi que le temps donné à chaque joueur pour jouer son coup 

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Character;
using TurnPlayer;

public class InGame : MonoBehaviour
{
    [SerializeField]    
    public TextMeshProUGUI role;

    public int resultRand;
    public InGame() {}
    public void goBackLastMenu() {
        SceneManager.LoadScene(1);
    }

    public Cupid cupid = new Cupid();
    public Hunter hunter = new Hunter();
    public Psychic psychic = new Psychic();
    public Witch witch = new Witch();
    public WereWolf wereWolf1 = new WereWolf("Loup-Garou 1");
    public WereWolf wereWolf2 = new WereWolf("Loup-Garou 2");
    public Turn turn;

    public float timeRemaining = 10;

    public int randomIdCharacter() {

        Debug.Log("Cupid = " + cupid.idCharacter + ", Hunter = " + hunter.idCharacter + ", Psychic = " + psychic.idCharacter + ", WereWolf1 = " + wereWolf1.idCharacter + ", WereWolf2 = " + wereWolf2.idCharacter + ", Witch = " + witch.idCharacter);

        //use random range for unityEngine
        resultRand = UnityEngine.Random.Range(1, 7);
        if (resultRand == null) {
            Debug.Log("Error random range");
            return 0;
        } else {
            return resultRand;
        }
    }

    public void randomThisCharacter() {
        turn = new Turn(cupid, hunter, psychic, wereWolf1, wereWolf2, witch);
        // //turn.timerToChangeCharacter();
        // turn.timerToChangeCharacter();
        turn.chooseActionTimer();
        // timerToChangeCharacter();
        int randomId = randomIdCharacter();

        AllCharacter[] randCharacter = {cupid, hunter, psychic, wereWolf1, wereWolf2, witch};
        // turn.turnPlayer(randCharacter);

        int randCharacterLenght = randCharacter.Length;

        for (int i = 0; i < randCharacterLenght; i++) {
            if (randCharacter[i].idCharacter == randomId) {
                role.text = randCharacter[i].nameOfCharacter;
                return;
            }

        }
    }

    public void timerToChangeCharacter() {
        Debug.Log("Time To change");
        if (timeRemaining > 0) {
            timeRemaining -= Time.deltaTime;
        }
        if (timeRemaining <= 0) {
            Debug.Log("Time : " + timeRemaining);
            Debug.Log("Time Passed");
            timeRemaining = 10;
        }
        // Debug.Log("Time : " + timeRemaining);
    }
}