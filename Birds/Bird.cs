using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    class Bird
    {
        private string ID;
        private string name;
        private string family;
        private string order;
        private string image;
        private string sound;

        public string id { get { return ID; } set { ID = value; } }
        public string Name {get { return name; } set { name = value; } }
        public string Family { get { return family; } set { family = value; } }
        public string Order { get { return order; } set { order = value; } }
        public string Image { get { return image; } set { image = value; } }
        public string Sound { get { return sound; } set { sound = value; } }

        public Bird()
        {

        }

        public Bird(string ID, string name, string family, string order)
        {
            this.ID = ID;
            this.name = name;
            this.family = family;
            this.order = order;
            this.image = ID+".jpg";
            this.sound = ID+".mp3";
        }




    }
}
