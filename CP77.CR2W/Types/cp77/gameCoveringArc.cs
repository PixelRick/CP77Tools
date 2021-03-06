using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCoveringArc : CVariable
	{
		[Ordinal(0)]  [RED("leftAngle")] public CFloat LeftAngle { get; set; }
		[Ordinal(1)]  [RED("rightAngle")] public CFloat RightAngle { get; set; }
		[Ordinal(2)]  [RED("verticalAngle")] public CFloat VerticalAngle { get; set; }

		public gameCoveringArc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
