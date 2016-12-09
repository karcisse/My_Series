using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySeries_app.model
{
    public class Series
    {
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        private uint season;
        public uint Season
        {
            get
            {
                return season;
            }
            set
            {
                season = value;
            }
        }
        private uint episode;
        public uint Episode
        {
            get
            {
                return episode;
            }
            set
            {
                episode = value;
            }
        }

        public Series(string title, uint season, uint episode)
        {
            Title = title;
            Season = season;
            Episode = episode;
        }
        public Series(string[] data)
        {
            try
            {
                Title = data[0];
                Season = UInt32.Parse(data[1]);
                Episode = UInt32.Parse(data[2]);
            }
            catch (IndexOutOfRangeException e)
            {
                Title = "error occured";
                Season = 0;
                Episode = 0;
                return;
            }
        }
    }
}
