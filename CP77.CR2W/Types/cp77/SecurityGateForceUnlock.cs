using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityGateForceUnlock : redEvent
	{
		[Ordinal(0)]  [RED("entranceAllowedFor")] public entEntityID EntranceAllowedFor { get; set; }
		[Ordinal(1)]  [RED("shouldUnlock")] public CBool ShouldUnlock { get; set; }

		public SecurityGateForceUnlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
