using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeamRipper.Models
{
    public struct Card
    {
        public static Card Balance => new Card("Balance", "Your mind suffers a wrenching alteration, causing your alignment to change. Lawful becomes chaotic, good becomes evil, and vice versa. If you are true neutral or unaligned, this card has no effect on you.");

        public static Card Comet => new Card("Comet", "If you single-handedly defeat the next hostile monster or group of Monsters you encounter, you gain experience points enough to gain one level. Otherwise, this card has no effect.");

        public static Card Donjon => new Card("Donjon", "You disappear and become entombed in a state of suspended animation in an extradimensional Sphere. Everything you were wearing and carrying stays behind in the space you occupied when you disappeared. You remain imprisoned until you are found and removed from the Sphere. You can't be located by any Divination magic, but a wish spell can reveal the location of your prison. You draw no more cards.");

        public static Card Euryale => new Card("Euryale", "The card's medusa-like visage curses you. You take a -2 penalty on saving throws while cursed in this way. Only a god or the magic of The Fates card can end this curse.");

        public static Card Fates => new Card("Fates", "Reality's fabric unravels and spins anew, allowing you to avoid or erase one event as if it never happened. You can use the card's magic as soon as you draw the card or at any other time before you die.");

        public static Card Flames => new Card("Flames", "A powerful devil becomes your enemy. The devil seeks your ruin and plagues your life, savoring your suffering before attempting to slay you. This enmity lasts until either you or the devil dies.");

        public static Card Fool => new Card("Fool", "You lose 10,000 XP, discard this card, and draw from the deck again, counting both draws as one of your declared draws. If losing that much XP would cause you to lose a level, you instead lose an amount that leaves you with just enough XP to keep your level.");

        public static Card Gem => new Card("Gem", "Twenty-five pieces of jewelry worth 2,000 gp each or fifty gems worth 1,000 gp each appear at your feet.");

        public static Card Idiot => new Card("Idiot", "Permanently reduce your Intelligence by 1d4 + 1 (to a minimum score of 1). You can draw one additional card beyond your declared draws.");

        public static Card Jester => new Card("Jester", "You gain 10,000 XP, or you can draw two additional cards beyond your declared draws.");

        public static Card Key => new Card("Key", "A rare or rarer Magic Weapon with which you are proficient appears in your hands. The DM chooses the weapon.");

        public static Card Knight => new Card("Knight", "You gain the service of a 4th-level Fighter who appears in a space you choose within 30 feet of you. The Fighter is of the same race as you and serves you loyally until death, believing the fates have drawn him or her to you. You control this character.");

        public static Card Moon => new Card("Moon", "You are granted the ability to cast the wish spell 1d3 times.");

        public static Card Rogue => new Card("Rogue", "A nonplayer character of the DM's choice becomes hostile toward you. The identity of your new enemy isn't known until the NPC or someone else reveals it. Nothing less than a wish spell or Divine Intervention can end the NPC's hostility toward you.");

        public static Card Ruin => new Card("Ruin", "All forms of wealth that you carry or own, other than Magic Items, are lost to you. Portable property vanishes. Businesses, buildings, and land you own are lost in a way that alters reality the least. Any documentation that proves you should own something lost to this card also disappears.");

        public static Card Skull => new Card("Skull", "You summon an avatar of death-a ghostly humanoid Skeleton clad in a tattered black robe and carrying a spectral scythe. It appears in a space of the DM's choice within 10 feet of you and attacks you, warning all others that you must win the battle alone. The avatar fights until you die or it drops to 0 hit points, whereupon it disappears. If anyone tries to help you, the helper summons its own avatar of death. A creature slain by an avatar of death can't be restored to life.");

        public static Card Star => new Card("Star", "Increase one of your Ability Scores by 2. The score can exceed 20 but can't exceed 24.");

        public static Card Sun => new Card("Sun", "You gain 50,000 XP, and a wondrous item (which the DM determines randomly) appears in your hands.");

        public static Card Talons => new Card("Talons", "Every magic item you wear or carry disintegrates. Artifacts in your possession aren't destroyed but do Vanish.");

        public static Card Throne => new Card("Throne", "You gain proficiency in the Persuasion skill, and you double your proficiency bonus on checks made with that skill. In addition, you gain rightful ownership of a small keep somewhere in the world. However, the keep is currently in the hands of Monsters, which you must clear out before you can claim the keep as. yours.");

        public static Card Vizier => new Card("Vizier", "At any time you choose within one year of drawing this card, you can ask a question in meditation and mentally receive a truthful answer to that question. Besides information, the answer helps you solve a puzzling problem or other dilemma. In other words, the knowledge comes with Wisdom on how to apply it.");

        public static Card Void => new Card("Void", "This black card Spells disaster. Your soul is drawn from your body and contained in an object in a place of the DM's choice. One or more powerful beings guard the place. While your soul is trapped in this way, your body is Incapacitated. A wish spell can't restore your soul, but the spell reveals the location of the object that holds it. You draw no more cards.");

        public Card(string name, string effect)
        {
            Name = name;
            Effect = effect;
        }


        public string Name
        {
            get;
            set;
        }

        public string Effect
        {
            get;
            set;
        }
    }
}
