using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class CharacterDatabase
    {
        public CharacterDatabase() : this(true)
        {
        }

        public CharacterDatabase(bool seed) : this(GetSeedCharacters(seed))
        {
        }

        private static Character[] GetSeedCharacters(bool seed)
        {
            if (!seed)
                return new Character[0];

            return new[] {
          new Character()
            {
                Name = "Sirilius",
                Description = "She is a Badass",
            },
          };
        }

        public CharacterDatabase(Character[] characters)
        {
            _items.AddRange(characters);
        }

        public void Add(Character character)
        {
            _items.Add(character);
        }

        public void Edit(string name, Character character)
        {
            Remove(name);
            Add(character);
        }

        public void Remove(string name)
        {
            var character = FindCharacter(name);
            if (character != null)
                _items.Remove(character);
        }

        private Character FindCharacter(string name)
        {
            foreach (var character in _items)
            {
                if (String.Compare(name, character.Name, true) == 0)
                    return character;
            };
            return null;
        }

        public Character[] GetAll()
        {
            var count = _items.Count;

            var temp = new Character[count];
            var index = 0;
            foreach (var character in _items)
            {
                temp[index++] = character;
            };
            return temp;
        }

        private List<Character> _items = new List<Character>();
    }
}
