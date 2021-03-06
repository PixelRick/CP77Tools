using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ApplyDiodeLightPresetEvent : redEvent
	{
		[Ordinal(0)]  [RED("delay")] public CFloat Delay { get; set; }
		[Ordinal(1)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(2)]  [RED("force")] public CBool Force { get; set; }
		[Ordinal(3)]  [RED("preset")] public DiodeLightPreset Preset { get; set; }

		public ApplyDiodeLightPresetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
