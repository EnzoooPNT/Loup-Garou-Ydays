using System;
namespace Character {
    public class Psychic : AllCharacter{

        public Psychic() : base() {
            this.nameOfCharacter = "Voyante";
            this.idCharacter = 3;
        }

        public string getRoleName(AllCharacter character) {
            return character.nameOfCharacter;
        }
    }
}