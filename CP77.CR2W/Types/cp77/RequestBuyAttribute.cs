using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RequestBuyAttribute : redEvent
	{
		[Ordinal(0)]  [RED("type")] public CEnum<gamedataStatType> Type { get; set; }

		public RequestBuyAttribute(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
