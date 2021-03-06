using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnInputSocketId : CVariable
	{
		[Ordinal(0)]  [RED("isockStamp")] public scnInputSocketStamp IsockStamp { get; set; }
		[Ordinal(1)]  [RED("nodeId")] public scnNodeId NodeId { get; set; }

		public scnInputSocketId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
