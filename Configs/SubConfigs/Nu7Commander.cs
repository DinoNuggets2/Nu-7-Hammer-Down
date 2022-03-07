namespace MtfUnitNu7.Configs.SubConfigs
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using Exiled.API.Enums;

    /// <summary>
    /// Configs for Nu7 Commander, equivalent of <see cref="RoleType.NtfCaptain"/>.
    /// </summary>
    public class Nu7Commander
    {
        /// <summary>
        /// Gets Nu7 Commander health.
        /// </summary>
        [Description("Nu7 Commander health.")]
        public float Health { get; private set; } = 130f;

        /// <summary>
        /// Gets Nu7 Commander inventory.
        /// </summary>
        [Description("Nu7 Commander inventory:")]
        public List<string> Inventory { get; private set; } = new List<string>
        {
            "KeycardNTFCommander",
            "GunE11SR",
            "GunCOM18",
            "Medkit",
            "Adrenaline",
            "Radio",
            "GrenadeFrag",
            "ArmorCombat",
        };

        /// <summary>
        /// Gets Nu7 Commander ammo.
        /// </summary>
        [Description("Nu7 Commander ammo:")]
        public Dictionary<AmmoType, ushort> Ammo { get; private set; } = new Dictionary<AmmoType, ushort>
        {
            { AmmoType.Nato556, 120 },
            { AmmoType.Nato762, 0 },
            { AmmoType.Nato9, 60 },
        };

        /// <summary>
        /// Gets Nu7 Commander rank seen in-game instead of standard NTF role.
        /// </summary>
        [Description("Nu7 Commander rank seen in-game.")]
        public string Rank { get; private set; } = "Nu-7 Commander";
    }
}
