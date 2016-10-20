// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HeroClassType.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Specifies the type of hero that can be played.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.D3.Core
{
    using System.ComponentModel;

    /// <summary>
    /// Specifies the type of hero that can be played.
    /// </summary>
    public enum HeroClassType
    {
        /// <summary>
        /// The Barbarian is a massive, heavily-armed warrior, a wanderer 
        /// from a tribe that once guarded the sacred Mount Arreat.
        /// </summary>
        [Description("Barbarian")]
        Barbarian,

        /// <summary>
        /// The Crusader is a champion of justice adorned with metal armor 
        /// and gleaming power. When evil emerges from its lair to twist and 
        /// destroy humankind, the Crusader charges.
        /// </summary>
        [Description("Crusader")]
        Crusader,

        /// <summary>
        /// The Demon Hunter is the survivor of a demonic attack who has 
        /// dedicated body and soul in an unending quest to rid the world of 
        /// the influence of the demons that threaten Sanctuary.
        /// </summary>
        [Description("Demon Hunter")]
        DemonHunter,

        /// <summary>
        /// The Monk is a holy warrior, a servant of the divine whose body 
        /// has been honed into a deadly weapon.
        /// </summary>
        [Description("Monk")]
        Monk,

        /// <summary>
        /// The Witch Doctor weaves the power of the spirits of the Unformed 
        /// Land, summoning creatures from beyond the grave.
        /// </summary>
        [Description("Witch Doctor")]
        WitchDoctor,

        /// <summary>
        /// The Wizard is an arcane prodigy who commands time and the 
        /// elements in the pursuit of destiny and power.
        /// </summary>
        [Description("Wizard")]
        Wizard,
    }
}
