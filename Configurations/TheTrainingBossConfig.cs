using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Localization;

namespace SFDevApril2023.Configurations
{
    public class TheTrainingBossConfig: ConfigSection
    {
        [ObjectInfo(Title = "FaceBookUsername", Description = "Please enter a FaceBookUsername")]
        [ConfigurationProperty("FaceBookUsername", DefaultValue = "")]
        public string FaceBookUsernameProperty
        {
            get
            {
                return (string)this["FaceBookUsername"];
            }
            set
            {
                this["FaceBookUsername"] = value;
            }
        }

        [ObjectInfo(Title = "FaceBookPassword", Description = "This is a FaceBookPassword field.")]
        [ConfigurationProperty("FaceBookPassword", DefaultValue = "")]
        public string FaceBookPasswordProperty
        {
            get
            {
                return (string)this["FaceBookPassword"];
            }
            set
            {
                this["FaceBookPassword"] = value;
            }
        }
    }
}