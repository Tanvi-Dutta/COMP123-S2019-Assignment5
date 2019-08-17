using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2019_Assignment5
{
    public class Hardware
    {
       /** public enum HardwareField
        {
            PRODUCT_ID,
            COST,
            MANUFACTURER,
            MODEL,
            RAM_TYPE,
            RAM_SIZE,
            DISPLAY_TYPE,
            SCREEN_SIZE,
            RESOLUTION,
            CPU_CLASS,
            CPU_BRAND,
            CPU_TYPE,
            CPU_SPEED,
            CPU_NUMBER,
            CONDITION,
            OS,
            PLATFORM,
            HDD_SIZE,
            HDD_SPEED,
            GPU_TYPE,
            OPTICAL_DRIVE,
            AUDIO_TYPE,
            LAN,
            WIFI,
            WIDTH,
            HEIGHT,
            DEPTH,
            WEIGHT,
            MOUSE_TYPE,
            POWER,
            WEBCAM,
            NUM_OF_FIELDS
        }**/
        //creating properties
        public int productID { get; set; }
        public double cost { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
        public string RAM_Type { get; set; }
        public string RAM_Size { get; set; }
        public string displayType { get; set; }
        public string screenSize { get; set; }
        public string resolution { get; set; }
        public string CPU_Class { get; set; }
        public string CPU_Brand { get; set; }
        public string CPU_Type { get; set; }
        public string CPU_Speed { get; set; }
        public string CPU_Number { get; set; }
        public string condition { get; set; }
        public string OS { get; set; }
        public string platform { get; set; }
        public string HDD_Size { get; set; }
        public string HDD_Speed { get; set; }
        public string GPU_Type { get; set; }
        public string optical_Drive { get; set; }
        public string audio_Type { get; set; }
        public string LAN { get; set; }
        public string WIFI { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string depth { get; set; }
        public string weigth { get; set; }
        public string mouse_Type { get; set; }
        public string power { get; set; }
        public string webcam { get; set; }
    }
}
