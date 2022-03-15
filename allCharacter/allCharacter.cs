using System;

namespace Character{
    public class AllCharacter {
        public string nameOfCharacter;
        public bool lifeOfCharacter;
        public int idCharacter;
        public bool love;
        public AllCharacter(string name, int id) {
            nameOfCharacter = name;
            lifeOfCharacter = true;
            idCharacter = id;
            if (nameOfCharacter != "Loup-Garou 1" || nameOfCharacter != "Loup-Garou 2") {
                love = false;
            }
        }
        public AllCharacter(){}
    }
}
