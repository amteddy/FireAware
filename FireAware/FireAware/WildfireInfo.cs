using System;
using System.Collections.Generic;
using System.Text;

namespace FireAware
{
    public class WildfireInfo
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string MapImage { get; set; } 
        public string RecommendationActions { get; set; } 
    } 

    public class WildfireInfoManager
    {
        private static List<WildfireInfo> wildfireInfoList;

        public WildfireInfoManager()
        {
            wildfireInfoList = new List<WildfireInfo>();
        }

        public void AddWildfireInfo(string name, string location, string mapImagePath, string recommendationActions)
        {
            WildfireInfo wildfireInfo = new WildfireInfo
            {
                Name = name,
                Location = location,
                MapImage = mapImagePath,
                RecommendationActions = recommendationActions
            };

            wildfireInfoList.Add(wildfireInfo);
        }

        public List<WildfireInfo> GetAllWildfireInfo()
        {
            return wildfireInfoList;
        }
    }

}
