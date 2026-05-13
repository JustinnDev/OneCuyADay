using Godot;
using static Godot.GD;

namespace Game.Autoload
{
    
    public partial class ScreenManager : Node
    {
        private Vector2I _screenSize = new (500 , 500);

        public override void _EnterTree()
        {
            Print($"{nameof(ScreenManager)} is {nameof(_EnterTree)}");   
        }

        public override void _Ready()
        {
            DisplayServer.WindowSetMode(DisplayServer.WindowMode.Windowed);
            DisplayServer.WindowSetFlag(DisplayServer.WindowFlags.ResizeDisabled, true);
            DisplayServer.WindowSetFlag(DisplayServer.WindowFlags.Borderless, true);
        }

        public override void _Process(double delta)
        {
            
        }

        private void _GetAvailableResolutions()
        {
            var screenSize = DisplayServer.ScreenGetSize();

            //if ()
            //{

            //}
        }
    }
}
