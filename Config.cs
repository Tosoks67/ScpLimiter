using PlayerRoles;

namespace ScpLimiter;

public class Config
{
    public int ScpLimit { get; set; } = 10;
    public RoleTypeId SubstituteRole { get; set; } = RoleTypeId.ClassD;
}
