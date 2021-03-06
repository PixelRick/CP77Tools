using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkButtonDpadSupportedController : inkButtonAnimatedController
	{
		[Ordinal(0)]  [RED("targetPath_DpadDown")] public wCHandle<inkWidget> TargetPath_DpadDown { get; set; }
		[Ordinal(1)]  [RED("targetPath_DpadLeft")] public wCHandle<inkWidget> TargetPath_DpadLeft { get; set; }
		[Ordinal(2)]  [RED("targetPath_DpadRight")] public wCHandle<inkWidget> TargetPath_DpadRight { get; set; }
		[Ordinal(3)]  [RED("targetPath_DpadUp")] public wCHandle<inkWidget> TargetPath_DpadUp { get; set; }

		public inkButtonDpadSupportedController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
