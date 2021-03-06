using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Ref_4_2_1_Class : IScriptable
	{
		[Ordinal(0)]  [RED("constValue")] public CInt32 ConstValue { get; set; }

		public Ref_4_2_1_Class(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
