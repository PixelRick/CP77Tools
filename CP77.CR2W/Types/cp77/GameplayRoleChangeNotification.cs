using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GameplayRoleChangeNotification : redEvent
	{
		[Ordinal(0)]  [RED("newRole")] public CEnum<EGameplayRole> NewRole { get; set; }
		[Ordinal(1)]  [RED("oldRole")] public CEnum<EGameplayRole> OldRole { get; set; }

		public GameplayRoleChangeNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
