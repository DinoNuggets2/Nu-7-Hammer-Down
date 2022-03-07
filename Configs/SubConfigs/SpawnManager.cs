namespace UIURescueSquad.Configs.SubConfigs
{
    using System.ComponentModel;
    using UnityEngine;

    /// <summary>
    /// Configs for Nu-7 spawning options.
    /// </summary>
    public class SpawnManager
    {
        /// <summary>
        /// Gets the number of respawn waves which must occur before considering Nu-7 to spawn.
        /// </summary>
        [Description("How many mtfs respawns must have happened to spawn Nu-7")]
        public int Respawns { get; private set; } = 1;

        /// <summary>
        /// Gets the chance for Nu-7 to spawn instead of NTF.
        /// </summary>
        [Description("Probability of a Nu-7 Squad replacing a MTF spawn")]
        public int Probability { get; private set; } = 20;

        /// <summary>
        /// Gets the maximum size of a Nu-7 squad.
        /// </summary>
        [Description("The maximum size of a Nu-7 squad")]
        public uint MaxSquad { get; private set; } = 20;

        /// <summary>
        /// Gets the Nu-7 spawn position.
        /// </summary>
        [Description("Nu-7 squad spawn position:")]
        public Vector3 SpawnPos { get; private set; } = new Vector3(69.846f, 994.04f, -48.71f);

        /// <summary>
        /// Gets the Nu-7 announcement message.
        /// </summary>
        [Description("Entrance broadcast announcement message (null to disable it)")]
        public string AnnouncementText { get; private set; } = string.Empty;

        /// <summary>
        /// Gets the Nu-7 announcement message display time.
        /// </summary>
        [Description("Entrance broadcast announcement message time")]
        public ushort AnnouncementTime { get; private set; } = 10;

        /// <summary>
        /// Gets the Nu-7 Cassie entrance message.
        /// </summary>
        [Description("Nu-7 entrance Cassie Message")]
        public string UiuAnnouncementCassie { get; private set; } = "MTFUnit Nu - 7 designated Hammer .g2 .g5 .g3 .g2 Down Unit {designation} HasEntered . AllRemaining . AwaitingRecontainment {scpnum}";

        /// <summary>
        /// Gets the Nu-7 Cassie entrance message, when there aren't any SCPs.
        /// </summary>
        public string UiuAnnouncmentCassieNoScp { get; private set; } = "MTFUnit Nu - 7 Designated Hammer .g2 .g4 .g1 Down Unit {designation} HasEntered . AllRemaining . NoSCPsLeft";

        /// <summary>
        /// Gets the custom NTF Cassie entrance message.
        /// </summary>
        [Description("NTF entrance Cassie Message (leave empty to use default NTF cassie entrance)")]
        public string NtfAnnouncementCassie { get; private set; } = string.Empty;

        /// <summary>
        /// Gets the custom NTF Cassie entrance message, when there aren't any SCPs.
        /// </summary>
        public string NtfAnnouncmentCassieNoScp { get; private set; } = string.Empty;

        /// <summary>
        /// Gets the Cassie glitch chance for custom announcements.
        /// </summary>
        [Description("Custom Cassie glitch chance.")]
        public float GlitchChance { get; private set; } = 0.05f;

        /// <summary>
        /// Gets the Cassie glitch chance for custom announcements.
        /// </summary>
        [Description("Custom Cassie jam chance.")]
        public float JamChance { get; private set; } = 0.05f;

        /// <summary>
        /// Gets a value indicating whether hints should be used instead of broadcasts.
        /// </summary>
        [Description("Use hints instead of broadcasts.")]
        public bool UseHints { get; private set; } = false;

        /// <summary>
        /// Gets an Nu-7 spawn broadcast.
        /// </summary>
        [Description("Nu-7 Player broadcast (null to disable it)")]
        public string UiuBroadcast { get; private set; } = sring.Empty;

        /// <summary>
        /// Gets an Nu-7 spawn broadcast time.
        /// </summary>
        [Description("Nu-7 Player broadcast time")]
        public ushort UiuBroadcastTime { get; private set; } = 10;
    }
}
