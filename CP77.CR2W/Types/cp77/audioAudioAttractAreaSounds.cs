using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAudioAttractAreaSounds : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("NPCgrunts")] public CArray<audioDynamicEventsPerVisualTags> NPCgrunts { get; set; }
		[Ordinal(1)]  [RED("environmentSounds")] public CArray<audioDynamicEventsWithInterval> EnvironmentSounds { get; set; }

		public audioAudioAttractAreaSounds(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
