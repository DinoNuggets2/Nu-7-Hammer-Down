namespace MtfUnitNu7.Configs.SubConfigs
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using Exiled.API.Enums;

    /// <summary>
    /// Configs for Nu7 Soilder, equivalent of <see cref="RoleType.NtfSergeant"/>.
    /// </summary>
    public class UiuAgent
    {
        /// <summary>
        /// Gets Nu7 Soilder health.
        /// </summary>
        [Description("Nu7 Soilder health.")]
        public float Health { get; private set; } = 100f;

        /// <summary>
        /// Gets Nu7 Soilder inventory.
        /// </summary>
        [Description("Nu7 Soilder inventory:")]
        public List<string> Inventory { get; private set; } = new List<string>
        {
            "KeycardNTFLieutenant",
            "GunE11SR",
            "GunCOM18",
            "Medkit",
            "Adrenaline",
            "Radio",
            "GrenadeFrag",
            "ArmorCombat",
        };

        /// <summary>
        /// Gets Nu7 Soilder ammo.
        /// </summary>
        [Description("Nu7 Soilder ammo:")]
        public Dictionary<AmmoType, ushort> Ammo { get; private set; } = new Dictionary<AmmoType, ushort>
        {
            { AmmoType.Nato556, 120 },
            { AmmoType.Nato762, 0 },
            { AmmoType.Nato9, 60 },
        };

        /// <summary>
        /// Gets Nu7 Soilder rank seen in-game instead of standard NTF role.
        /// </summary>
        [Description("Nu7 Soilder rank seen in-game.")]
        public string Rank { get; private set; } = "Nu-7 Soilder";
    }
}
