using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIInjectCombatThreatCommand : AICombatRelatedCommand
	{
		[Ordinal(0)]  [RED("dontForceHostileAttitude")] public CBool DontForceHostileAttitude { get; set; }
		[Ordinal(1)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(2)]  [RED("isPersistent")] public CBool IsPersistent { get; set; }
		[Ordinal(3)]  [RED("targetNodeRef")] public NodeRef TargetNodeRef { get; set; }
		[Ordinal(4)]  [RED("targetPuppetRef")] public gameEntityReference TargetPuppetRef { get; set; }

		public AIInjectCombatThreatCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
