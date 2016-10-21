// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FollowerType.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Specifies the type of follower that can be hired.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.D3.Core
{
    /// <summary>
    ///   Specifies the type of follower that can be hired.
    /// </summary>
    public enum FollowerSelection
    {
        /// <summary>
        /// Eirena, the Enchantress, a mysterious magic-user who can confuse 
        /// and debilitate enemies.
        /// </summary>
        Enchantress,

        /// <summary>
        /// Lyndon, the Scoundrel, a selfish rake skilled in larceny and 
        /// ranged weapons.
        /// </summary>
        Scoundrel,

        /// <summary>
        /// Kormac, the Templar, a dedicated master of melee arms and armor.
        /// </summary>
        Templar,
    }
}