using System;
using UnityEngine;


namespace Character {
    public class Hunter : AllCharacter {

        public int idDie;
        public Hunter() : base() {
            this.nameOfCharacter = "Chasseur";
            this.idCharacter = 2;
            this.idDie = 0;
            hunterDie();
        }
 
        public void killSomeone(AllCharacter character) {
            if (lifeOfCharacter == false && idDie == 1) {
                character.lifeOfCharacter = false;
                return;
            }
        }

        public void hunterDie() {
            if (lifeOfCharacter == false) {
                idDie++;
            }
        }
        
    }

}