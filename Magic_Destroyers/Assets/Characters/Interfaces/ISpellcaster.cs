using Assets.Characters.Melees;
using Assets.Equipment.Spells;

namespace Magic_Destroyers.Interfaces
{
    public interface ISpellcaster
    {
        Spell MySpell { get; set; }
        int Mana { get; set; }

        void CastSpell(Melee character);
    }
}
