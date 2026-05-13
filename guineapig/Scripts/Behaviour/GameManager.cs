using Godot;
using Game.Resources;
using static Godot.GD;

namespace Game
{
    public partial class GameManager : Node2D
    {
        private GridContainer _container;

        public override void _Ready()
        {         
            var cuys = ResourcesManager.LoadCuys();

            _container = GetNode<GridContainer>("Control/GridContainer");
            _container.Columns = cuys.Length;


            foreach (var cuy in cuys)
            {
                
                var texture = new TextureRect();
                texture.Texture = cuy.Texture;
                texture.CustomMinimumSize = new Vector2(200,200);

                _container.AddChild(texture);    
            }
        }

        public override void _Process(double delta)
        {

        }
    }
}

