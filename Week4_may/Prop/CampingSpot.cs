using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prop
{
    class CampingSpot
    {
        private string spot_type;
        private int spot_id;
        private int id;
        private string rfid_assigned;
        public string RFID_assigned { get { return this.rfid_assigned; } }
        public int spot_number { get { return this.spot_id; } }
        public string Type { get { return this.spot_type; } }
        public CampingSpot(int spot_id, int id, string spot_type, string rfid_assigned)
        {
            this.spot_id = spot_id;
            this.id = id;
            this.spot_type = spot_type;
            this.rfid_assigned = rfid_assigned;
        }
        public string GetInfo()
        {
            return "this is spot number " + this.spot_id+ " and is for " +spot_type.ToString()+ " people at max";
        }
        
    }
}
