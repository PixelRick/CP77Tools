using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VirtualSystemPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("owner")] public wCHandle<MasterControllerPS> Owner { get; set; }
		[Ordinal(1)]  [RED("slaves")] public CArray<CHandle<gameDeviceComponentPS>> Slaves { get; set; }
		[Ordinal(2)]  [RED("slavesCached")] public CBool SlavesCached { get; set; }

		public VirtualSystemPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
