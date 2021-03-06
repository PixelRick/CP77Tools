using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerSetMeshAppearance_NodeTypeParams : CVariable
	{
		[Ordinal(0)]  [RED("appearanceName")] public CName AppearanceName { get; set; }
		[Ordinal(1)]  [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(2)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(3)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }

		public questEntityManagerSetMeshAppearance_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
