using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class locVoiceTag : CVariable
	{
		[Ordinal(0)]  [RED("id")] public CRUID Id { get; set; }
		[Ordinal(1)]  [RED("isApuc")] public CBool IsApuc { get; set; }
		[Ordinal(2)]  [RED("voiceTag")] public CName VoiceTag { get; set; }
		[Ordinal(3)]  [RED("voicesetScenePath")] public CString VoicesetScenePath { get; set; }

		public locVoiceTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
