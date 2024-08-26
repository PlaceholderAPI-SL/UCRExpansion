using Exiled.API.Features;
using PlaceholderAPI.API.Abstract;
using PlayerRoles;
using UncomplicatedCustomRoles.API.Features;
using UncomplicatedCustomRoles.Extensions;

namespace UCRExpansion
{
    public class UCRExpansion : PlaceholderExpansion
    {
        public override string Author { get; set; } = "NotZer0Two";
        public override string Identifier { get; set; } = "ucr";
        public override string RequiredPlugin { get; set; } = "UncomplicatedCustomRoles";

        public override string OnRequest(Player player, string param)
        {
            player.TryGetSummonedInstance(out SummonedCustomRole role);

            switch (param.ToLower())
            {
                case "hascustomrole":
                    return player.HasCustomRole().ToString();
                case "role_id":
                    return role != null ? role.Role.Id.ToString() : null;
                case "role_name":
                    return role != null ? role.Role.Name : null;
                case "role_nickname":
                    return role != null ? role.Role.Nickname : null;
                case "role_custominfo":
                    return role != null ? role.Role.CustomInfo : null;
                case "role_badgename":
                    return role != null ? role.Role.BadgeName : null;
                case "role_badgecolor":
                    return role != null ? role.Role.BadgeColor : null;
                case "role_baserole":
                    return role != null ? role.Role.Role.ToString() : null;
                case "role_team":
                    return role != null ? role.Role.Team == null ? role.Player.Role.Team.ToString() : role.Role.Team.ToString() : null;
                case "role_health":
                    return role != null ? role.Role.Health.ToString() : null;
                case "role_ahp":
                    return role != null ? role.Role.Ahp.ToString() : null;
                case "role_stamina":
                    return role != null ? role.Role.Stamina.ToString() : null;
                case "role_scp330max":
                    return role != null ? role.Role.MaxScp330Candies.ToString() : null;
                case "role_canescape":
                    return role != null ? role.Role.CanEscape.ToString() : null;
                case "role_damagemultiplier":
                    return role != null ? role.Role.DamageMultiplier.ToString() : null;
                case "role_ignorespawn":
                    return role != null ? role.Role.IgnoreSpawnSystem.ToString() : null;
            }

            return null;
        }

    }
}
