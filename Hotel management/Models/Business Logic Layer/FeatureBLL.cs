using Hotel_management.Models.Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management.Models.Business_Logic_Layer
{
    internal class FeatureBLL
    {
        FeatureDAL featureDAL = new FeatureDAL();
        public void AddFeature(Feature feature)
        {
            featureDAL.AddFeature(feature);
        }


        public void ModifyFeature(Feature feature)
        {
            featureDAL.ModifyFeature(feature);
        }

        public void DeleteFeature(long id)
        {
            featureDAL.DeleteFeature(id);
        }
    }
}