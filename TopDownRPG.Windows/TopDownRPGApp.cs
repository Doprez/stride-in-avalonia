using Stride.Engine;
using Stride.Games;

namespace TopDownRPG
{
    class TopDownRPGApp
    {
        static void Main(string[] args)
        {
            var sdlWindow = new Stride.Graphics.SDL.Window("Embedded Stride Window");
            var context = new GameContextSDL(sdlWindow, sdlWindow.Size.Width, sdlWindow.Size.Height);
            using (var game = new Game())
            {
                game.Run(context);
            }
        }
    }
}
