using System;
using System.Collections.Generic;
using System.Text;

namespace Hero_Recruitment
{
    class Heroes
    {
        public string Name { get; set; }
        public List<string> spellbook { get; set; }

        public Heroes(string name)
        {
            this.Name = name;
            this.spellbook = new List<string>();
        }
        public void AddSpellName(string spellName)
        {
            this.spellbook.Add(spellName);
        }
        public void RemoveSpellName(string spell)
        {
            this.spellbook.Remove(spell);
        }
    }
}
