using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using Rocket.API;

namespace ZaupFeast
{
	public class FeastConfiguration : IRocketPluginConfiguration
	{
        public bool Enabled;
		public int MinDropTime;
		public int MaxDropTime;
		public byte DropRadius;
		public byte MinItemsDrop;
		public byte MaxItemsDrop;
        public bool SkyDrop;
        public ushort PlaneEffectId;
        public ushort SkydropEffectId;
        public string MessageColor;
        public List<FeastItem> Items;

        public void LoadDefaults()
        {
            Enabled = true;
		    MinDropTime = 600;
		    MaxDropTime = 1200;
		    DropRadius = 20;
		    MinItemsDrop = 10;
		    MaxItemsDrop = 25;
            SkyDrop = false;
            PlaneEffectId = 1001;
            SkydropEffectId = 1006;
            MessageColor = "red";
            Items = new List<FeastItem>
		    {
			    new FeastItem(1021, "Avenger", 5, new List<string>
			    {
				    "all"
			    }),
			    new FeastItem(43, "Military Ammunition Box", 5, new List<string>
			    {
				    "all"
			    }),
			    new FeastItem(147, "Halo Sight", 2, new List<string>
			    {
				    "all"
			    }),
			    new FeastItem(1022, "Avenger Magazine", 3, new List<string>
			    {
				    "all"
			    }),
			    new FeastItem(143, "Bipod", 6, new List<string>
			    {
				    "all"
			    }),
			    new FeastItem(253, "Alicepack", 3, new List<string>
			    {
				    "all"
			    }),
			    new FeastItem(1018, "Sabertooth", 1, new List<string>
			    {
				    "all"
			    }),
			    new FeastItem(1020, "Sabertooth Magazine", 2, new List<string>
			    {
				    "all"
			    }),
			    new FeastItem(1113, "Snare", 5, new List<string>
			    {
				    "all"
			    }),
			    new FeastItem(1132, "Snowball", 1, new List<string>
			    {
				    "all"
			    }),
			    new FeastItem(355, "Blue Flare", 10, new List<string>
			    {
				    "all"
			    }),
			    new FeastItem(1244, "Sentry", 3, new List<string>
			    {
				    "all"
			    })
		    };
        }
	}
}
