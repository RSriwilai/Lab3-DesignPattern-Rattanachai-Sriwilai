using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class HouseFactory
    {
        private Dictionary<string, Type> _house;

        public HouseFactory()
        {
            _house = LoadHouseReflection();
        }

        public House CreateHouse(string houseName)
        {
            return GetHouseFromDictionary(houseName.ToLower());
        }


        private Dictionary<string, Type> LoadHouseReflection()
        {
            IEnumerable<Type> availableHouseTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(h => h.IsClass && h.IsSubclassOf(typeof(House)));


            Dictionary<string, Type> availableHouses = new Dictionary<string, Type>();

            foreach (Type h in availableHouseTypes)
            {
                availableHouses.Add(h.Name.ToLower(), h);
            }
            return availableHouses;
        }


        private House GetHouseFromDictionary(string houseName)
        {
            Type type = _house[houseName];
            if (type is null)
            {
                throw new ArgumentException("Could not find house with name" + houseName);
            }
            return (House)Activator.CreateInstance(type);
        }

    }
}
