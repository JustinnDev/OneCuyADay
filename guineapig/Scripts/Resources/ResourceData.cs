using Godot;

namespace Game.Resources
{
    public partial class ResourceData : Resource
    {
        [Export] public string Name;
        [Export] public Texture2D Texture;
    }
}
