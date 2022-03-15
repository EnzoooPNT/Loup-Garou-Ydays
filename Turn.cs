using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using UnityEngine;
using Character;

namespace TurnPlayer
{

    public class Turn : MonoBehaviour
    {
        public AllCharacter cupid;
        public AllCharacter hunter;
        public AllCharacter psychic;
        public AllCharacter wereWolf1;
        public AllCharacter wereWolf2;
        public AllCharacter witch;

        public Turn() {}

        

        public static int index = 0;

        // public float timeRemaining = 10;

        public Turn(AllCharacter cupid, AllCharacter hunter, AllCharacter psychic, AllCharacter wereWolf1, AllCharacter wereWolf2, AllCharacter witch) {
            this.cupid = cupid;
            this.hunter = hunter;
            this.psychic = psychic;
            this.wereWolf1 = wereWolf1;
            this.wereWolf2 = wereWolf2;
            this.witch = witch;
        }

        public void displayCupidName() {
            Debug.Log(wereWolf1.nameOfCharacter);
        }

        // public void timerToChangeCharacter() {
        //     if (timeRemaining > 0)
        //     {
        //         timeRemaining -= Time.deltaTime;
        //     } else {
        //         Debug.Log("Time Passed");
        //         timeRemaining = 10;
        //     }

        // }
        public void turnPlayer(AllCharacter[] arrayOfCharacters) {
            int index = 0;
            bool myTurn = true;
            for(int i = 0; i < arrayOfCharacters.Length; i++){
                if(i == arrayOfCharacters.Length-1){
                    index++;
                    i = 0; 
                }
                if (index == 2) {
                    break;
                }
    
            } 
        }

        public void chooseActionTimer() {
            System.Timers.Timer timer = new System.Timers.Timer(1000);

            if (index > 10) {
                timer.Stop();
            } else {
                timer.Elapsed += TimerCallback;
            }
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e) {
            index++;
            Debug.Log(index);
            // Debug.Log(e);
        }

    }
}