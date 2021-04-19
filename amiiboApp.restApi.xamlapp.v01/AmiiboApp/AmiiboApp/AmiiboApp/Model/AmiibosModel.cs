﻿
namespace AmiiboApp.Model
{
        public class AmiibosModel
        {
            public Amiibo[] amiibo { get; set; }
        }    

        public class Amiibo
        {
            //Propiedades de un Amiibo
            public string amiiboSeries { get; set; }
            public string character { get; set; }
            public string gameSeries { get; set; }
            public string head { get; set; }
            public string image { get; set; }
            public string name { get; set; }
            public Release release { get; set; }
            public string tail { get; set; }
            public string type { get; set; }
        }

        public class Release
        {
            public string au { get; set; }
            public string eu { get; set; }
            public string jp { get; set; }
            public string na { get; set; }
        }
}
