namespace MtfUnitNu7.Configs.SubConfigs
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using Exiled.API.Enums;

    /// <summary>
    /// Configs for Nu7 Combative, equivalent of <see cref="RoleType.NtfPrivate"/>.
    /// </summary>
    public class Nu7Combative
    {
        /// <summary>
        /// Gets Nu7 Combative health.
        /// </summary>
        [Description("Nu7 Combative health.")]
        public float Health { get; private set; } = 100f;

        /// <summary>
        /// Gets Nu7 Combative inventory.
        /// </summary>
        [Description("Nu7 Combative inventory:")]
        public List<string> Inventory { get; private set; } = new List<string>
        {
            "KeycardNTFLieutenant",
            "GunShotgun",
            "GunCOM18",
            "Medkit",
            "Adrenaline",
            "Radio",
            "GrenadeFrag",
            "ArmorCombat",
        };

        /// <summary>
        /// Gets Nu7 Combative ammo.
        /// </summary>
        [Description("Nu7 Combative ammo:")]
        public Dictionary<AmmoType, ushort> Ammo { get; private set; } = new Dictionary<AmmoType, ushort>
        {
            { AmmoType.Nato556, 0 },
            { AmmoType.Nato762, 0 },
            { AmmoType.Nato9, 60 },
            { AmmoType.Ammo12Gauge, 48 },
        };

        /// <summary>
        /// Gets Nu7 Combative rank seen in-game instead of standard NTF role.
        /// </summary>
        [Description("Nu7 Combative rank seen in-game.")]
        public string Rank { get; private set; } = "Nu-7 Combative";
    }
}
