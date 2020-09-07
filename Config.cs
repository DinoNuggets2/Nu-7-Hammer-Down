﻿using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace UIURescueSquad
{
    public sealed class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Probability of a UIU Squad replacing a MTF spawn")]
        public float probability { get; set; } = 50f;

        [Description("Use hints instead of broadcasts?")]
        public bool UseHints { get; set; } = false;
        [Description("Entrance announcement message (null to disable it)")]
        public string AnnouncementText { get; set; } = "<b>The <color=#FFFA4B>UIU Rescue Squad</color> has arrived to the facility</b>";
        [Description("Entrance announcement message time")]
        public ushort AnnouncementTime { get; set; } = 10;

        [Description("UIU Player broadcast (null to disable it)")]
        public string UIUBroadcast { get; set; } = "<i>You are an</i><color=yellow><b> UIU trooper</b></color>, <i>help </i><color=#0377fc><b>MTFs</b></color><i> to finish its job</i>";
        [Description("UIU Player broadcast (null to disable it)")]
        public ushort UIUBroadcastTime { get; set; } = 10;

        [Description("UIU Soldier life (NTF CADET)")]
        public int UIUSoldierLife { get; set; } = 160;
        [Description("The items UIUs soldiers spawn with.")]
        public List<ItemType> UIUSoldierInventory { get; set; } = new List<ItemType>() { ItemType.KeycardNTFLieutenant, ItemType.GunProject90, ItemType.GunUSP, ItemType.Disarmer, ItemType.Medkit, ItemType.Adrenaline, ItemType.Radio, ItemType.GrenadeFrag };
        [Description("UIU Soldier Rank (THE BADGE ON THE LIST)")]
        public string UIUSoldierRank { get; set; } = "UIU Soldier";

        [Description("UIU Agent life (NTF LIEUTENANT)")]
        public int UIUAgentLife { get; set; } = 175;
        [Description("The items UIUs agents spawn with.")]
        public List<ItemType> UIUAgentInventory { get; set; } = new List<ItemType>() { ItemType.KeycardNTFLieutenant, ItemType.GunProject90, ItemType.GunUSP, ItemType.Disarmer, ItemType.Medkit, ItemType.Adrenaline, ItemType.Radio, ItemType.GrenadeFrag };
        [Description("UIU Agent Rank (THE BADGE ON THE LIST)")]
        public string UIUAgentRank { get; set; } = "UIU Agent";

        [Description("UIU Leader life (NTF COMMANDER)")]
        public int UIULeaderLife { get; set; } = 215;
        [Description("The items UIU leader spawn with.")]
        public List<ItemType> UIULeaderInventory { get; set; } = new List<ItemType>() { ItemType.KeycardNTFLieutenant, ItemType.GunProject90, ItemType.GunUSP, ItemType.Disarmer, ItemType.Medkit, ItemType.Adrenaline, ItemType.Radio, ItemType.GrenadeFrag };
        [Description("UIU Leader Rank (THE BADGE ON THE LIST)")]
        public string UIULeaderRank { get; set; } = "UIU Leader";
    }
}