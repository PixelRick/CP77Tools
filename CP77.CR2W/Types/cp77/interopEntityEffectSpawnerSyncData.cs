using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopEntityEffectSpawnerSyncData : CVariable
	{
		[Ordinal(0)]  [RED("componentID")] public EditorObjectID ComponentID { get; set; }
		[Ordinal(1)]  [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(2)]  [RED("componentParentID")] public EditorObjectID ComponentParentID { get; set; }
		[Ordinal(3)]  [RED("effects")] public CArray<interopEntityEffectSelectionSyncData> Effects { get; set; }
		[Ordinal(4)]  [RED("included")] public CBool Included { get; set; }
		[Ordinal(5)]  [RED("templateColor")] public CColor TemplateColor { get; set; }
		[Ordinal(6)]  [RED("templatePath")] public CString TemplatePath { get; set; }

		public interopEntityEffectSpawnerSyncData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
