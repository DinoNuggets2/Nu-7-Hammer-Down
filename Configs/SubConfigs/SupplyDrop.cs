namespace MtfUnitNu7.Configs.SubConfigs
{
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    /// Configs for Nu7 supply drop.
    /// </summary>
    public class SupplyDrop
    {
        /// <summary>
        /// Gets a value indicating whether supply drops for Nu7 are enabled.
        /// </summary>
        [Description("Should a drop spawn with Nu7")]
        public bool DropEnabled { get; private set; } = false;

        /// <summary>
        /// Gets a items for a Nu7 supply drop.
        /// </summary>
        [Description("List of items that appears in a drop (supports CustomItems)")]
        public Dictionary<string, uint> DropItems { get; private set; } = new Dictionary<string, uint>
        {
            { "Medkit", 1 },
            { "Ammo556", 2 },
        };
    }
}
