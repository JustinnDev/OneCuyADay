using Godot;
using System.Collections.Generic;
using static Godot.GD;

namespace Game.Resources
{
    public static class ResourcesManager
    {
        public static readonly string CuyResourcesPath = "res://Prefabs/Cuys/";

        public static CuyData[] LoadCuys()
        {
            return LoadResources<CuyData>(CuyResourcesPath); 
        }

        private static T[] LoadResources<T>(string resPath) where T : class
        {
            var dir = DirAccess.Open(resPath);
            
            if(dir == null)
            {
                PrintErr($"dir path {resPath} is not found");
                return null;
            }

            List<T> resources = new();
            dir.ListDirBegin();

            for(int i = 0; ; i++)
            {
                var fileName = dir.GetNext();

                if (fileName == "")
                    break;

                resources.Add(Load<T>(resPath + fileName) ?? null);
            }

            return resources.ToArray();
        }
    }
}
