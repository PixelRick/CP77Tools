using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldConversationData : ISerializable
	{
		[Ordinal(0)]  [RED("condition")] public CHandle<questIBaseCondition> Condition { get; set; }
		[Ordinal(1)]  [RED("ignoreGlobalLimit")] public CBool IgnoreGlobalLimit { get; set; }
		[Ordinal(2)]  [RED("ignoreLocalLimit")] public CBool IgnoreLocalLimit { get; set; }
		[Ordinal(3)]  [RED("interruptionOperations")] public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations { get; set; }
		[Ordinal(4)]  [RED("sceneFilename")] public raRef<scnSceneResource> SceneFilename { get; set; }

		public worldConversationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
