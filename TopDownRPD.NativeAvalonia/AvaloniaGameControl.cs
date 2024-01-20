using Avalonia.Controls;
using Avalonia.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDownRPD.NativeAvalonia;
public class AvaloniaGameControl : NativeControlHost
{
	protected override IPlatformHandle CreateNativeControlCore(IPlatformHandle parent)
	{
		return base.CreateNativeControlCore(parent);
	}
}
