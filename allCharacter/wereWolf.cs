//Les varibales de la classe parent sont définit ci-dessous

using System;
namespace Character {
    public class WereWolf : AllCharacter{

        private static int idIncrement = 0;

        public WereWolf(string name) : base() {
            this.nameOfCharacter = name;
            idIncrement++;
            this.idCharacter = idIncrement;
        }

        public bool killSomeone(AllCharacter character) {
            if (character.lifeOfCharacter == true) {
                character.lifeOfCharacter = false;
            } 
            return character.lifeOfCharacter;
        }
    }
}