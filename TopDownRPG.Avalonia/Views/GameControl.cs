using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;
using Stride.Engine;
using Stride.Games;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Interop;

namespace TopDownRPG.Avalonia.Views;

public partial class GameControl : NativeControlHost
{
	private Game? _game; 
	private Stride.Graphics.SDL.Window? _sdlWindow;

	public GameControl()
    {
        Loaded += GameControl_Loaded;
    }

	private void GameControl_Loaded(object? sender, RoutedEventArgs e)
	{
		InvalidateMeasure(); // force refresh
		var context = new GameContextSDL(_sdlWindow, _sdlWindow.Size.Width, _sdlWindow.Size.Height);
		
		// Start the game
		_game = new();


		_game.Run(context);
		//Task.Factory.StartNew(() =>
		//{
		//	// Running the game in its own task allows rendering while
		//	// dragging and resizing the window.
		//	_game.Run(context);
		//}, TaskCreationOptions.LongRunning);
	}

	protected override IPlatformHandle CreateNativeControlCore(IPlatformHandle parent)
	{
		var handle = base.CreateNativeControlCore(parent);
		
		// Create SDL window using child
		_sdlWindow = new Stride.Graphics.SDL.Window("Embedded Stride Window", handle.Handle);

        return new PlatformHandle(_sdlWindow.Handle, "Sdl2Hwnd");
    }
}