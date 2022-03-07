namespace MtfUnitNu7.Configs
{
    using System.ComponentModel;
    using Exiled.API.Interfaces;
    using SubConfigs;

    /// <inheritdoc cref="IConfig"/>
    public class Config : IConfig
    {
        /// <inheritdoc/>
        [Description("Is the plugin enabled.")]
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether debug mode is enabled.
        /// </summary>
        [Description("Should debug messages be shown in a server console.")]
        public bool Debug { get; set; } = false;

        /// <summary>
        /// Gets a <see cref="SpawnManager"/> configs.
        /// </summary>
        [Description("Options for Nu7 spawn:")]
        public SpawnManager SpawnManager { get; private set; } = new SpawnManager();

        /// <summary>
        /// Gets a <see cref="Nu7Commander"/> configs.
        /// </summary>
        [Description("Options for Nu7 Captain:")]
        public Nu7Commander Nu7Commander { get; private set; } = new Nu7Commander();

        /// <summary>
        /// Gets a <see cref="Nu7Soilder"/> configs.
        /// </summary>
        [Description("Options for Nu7 Soilder:")]
        public Nu7Soilder Nu7Soilder { get; private set; } = new Nu7Soilder();

        /// <summary>
        /// Gets a <see cref="Nu7Combative"/> configs.
        /// </summary>
        [Description("Options for Nu7 Combative:")]
        public Nu7Combative Nu7Combative { get; private set; } = new Nu7Combative();

        /// <summary>
        /// Gets a <see cref="TeamColors"/> configs.
        /// </summary>
        [Description("Options for custom team colors:")]
        public TeamColors TeamColors { get; private set; } = new TeamColors();

        /// <summary>
        /// Gets a <see cref="SupplyDrop"/> configs.
        /// </summary>
        [Description("Option for Nu7 supply drop:")]
        public SupplyDrop SupplyDrop { get; private set; } = new SupplyDrop();
    }
}
