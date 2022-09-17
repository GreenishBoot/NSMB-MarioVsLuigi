using System.Collections.Generic;

using Fusion;

namespace NSMB.Utils {
    public static class NetworkUtils {

        public static Dictionary<ShutdownReason, string> disconnectMessages = new() {

            [ShutdownReason.MaxCcuReached] = "Max player count reached in this region (100 players MAX)",
            [ShutdownReason.CustomAuthenticationFailed] = "Failed to authenticate with the auth server",
            //[DisconnectCause.DisconnectByServerLogic] = "",

        };

        private readonly static Dictionary<string, SessionProperty> _defaultRoomProperties = new() {
            [Enums.NetRoomProperties.Level] = 0,
            [Enums.NetRoomProperties.StarRequirement] = 10,
            [Enums.NetRoomProperties.CoinRequirement] = 8,
            [Enums.NetRoomProperties.Lives] = -1,
            [Enums.NetRoomProperties.Time] = -1,
            [Enums.NetRoomProperties.DrawTime] = 0,
            [Enums.NetRoomProperties.NewPowerups] = 1,
            [Enums.NetRoomProperties.GameStarted] = 0,
            [Enums.NetRoomProperties.HostName] = "",
            [Enums.NetRoomProperties.Mutes] = "",
            [Enums.NetRoomProperties.Bans] = "",
        };

        public static Dictionary<string, SessionProperty> DefaultRoomProperties {
            get => new(_defaultRoomProperties);
        }

        public static readonly string[] LobbyVisibleRoomProperties = new string[] {
            Enums.NetRoomProperties.Lives,
            Enums.NetRoomProperties.StarRequirement,
            Enums.NetRoomProperties.CoinRequirement,
            Enums.NetRoomProperties.Time,
            Enums.NetRoomProperties.NewPowerups,
            Enums.NetRoomProperties.GameStarted,
            Enums.NetRoomProperties.HostName,
        };
    }
}