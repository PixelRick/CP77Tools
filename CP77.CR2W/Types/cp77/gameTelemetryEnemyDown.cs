using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryEnemyDown : CVariable
	{
		[Ordinal(0)]  [RED("enemy")] public gameTelemetryEnemy Enemy { get; set; }
		[Ordinal(1)]  [RED("killType")] public CEnum<gameKillType> KillType { get; set; }
		[Ordinal(2)]  [RED("situation")] public CEnum<gameTelemetryDamageSituation> Situation { get; set; }

		public gameTelemetryEnemyDown(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
