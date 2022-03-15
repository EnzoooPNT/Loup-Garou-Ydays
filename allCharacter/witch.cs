using System;
namespace Character {
    public class Witch : AllCharacter{
        public Witch() : base() {
            this.nameOfCharacter = "Sorcière";
            this.idCharacter = 4;
        }

        public void killSomeone(AllCharacter character) {
            if (character.lifeOfCharacter) {
                character.lifeOfCharacter = false;
            }
        }

        public void reviveSomeone(AllCharacter character) {
            if (!character.lifeOfCharacter) {
                character.lifeOfCharacter = true;
            }
        }

    }
}