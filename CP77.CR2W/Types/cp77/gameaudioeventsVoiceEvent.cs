using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsVoiceEvent : redEvent
	{
		[Ordinal(0)]  [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(1)]  [RED("gruntInterruptMode")] public CEnum<audioVoGruntInterruptMode> GruntInterruptMode { get; set; }
		[Ordinal(2)]  [RED("gruntType")] public CEnum<audioVoGruntType> GruntType { get; set; }
		[Ordinal(3)]  [RED("isV")] public CBool IsV { get; set; }

		public gameaudioeventsVoiceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
