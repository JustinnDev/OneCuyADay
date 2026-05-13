using Godot;
using Game.Enums;

namespace Game.Resources
{
    [GlobalClass]
    public partial class CuyData : ResourceData
    {
        [Export] public CuyBreed Breed;
        [Export] public CuyRarity Rarity;
        [Export] public FoodData FavoriteFood;
    }
}
