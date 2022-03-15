//Les varibales de la classe parent sont définit ci-dessous

using System;

namespace Character {
    public class Cupid : AllCharacter {
        public Cupid() : base() {
            this.nameOfCharacter = "Cupidon";
            this.idCharacter = 1;
        }

        public void coupleCreation(AllCharacter character1, AllCharacter character2) {
            character1.love = true;
            character2.love = true;
            if (character1.lifeOfCharacter && !character2.lifeOfCharacter) {
                character1.lifeOfCharacter = false;
            } else if (!character1.lifeOfCharacter && character2.lifeOfCharacter) {
                character2.lifeOfCharacter = false;
            } else {
                return;
            }
        }
    }
}