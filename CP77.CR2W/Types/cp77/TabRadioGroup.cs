using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TabRadioGroup : inkRadioGroupController
	{
		[Ordinal(0)]  [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(1)]  [RED("root")] public inkCompoundWidgetReference Root { get; set; }
		[Ordinal(2)]  [RED("toggles")] public CArray<wCHandle<TabButtonController>> Toggles { get; set; }

		public TabRadioGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
