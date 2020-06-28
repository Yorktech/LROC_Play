using System;

namespace lroc_Data_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class LrocRecord
    {
        public string VOLUME_ID { get; set; }
        public string FILE_SPECIFICATION_NAME { get; set; }
        public string INSTRUMENT_HOST_ID { get; set; }
        public string INSTRUMENT_ID { get; set; }
        public string ORIGINAL_PRODUCT_ID { get; set; }
        public string PRODUCT_ID { get; set; }
        public string PRODUCT_VERSION_ID { get; set; }
        public string TARGET_NAME { get; set; }
        public int  ORBIT_NUMBER { get; set; }
        public decimal SLEW_ANGLE { get; set; }
        public string MISSION_PHASE_NAME { get; set; }
        public string RATIONALE_DESC { get; set; }
        public int  DATA_QUALITY_ID { get; set; }
        public  string NAC_PREROLL_START_TIME { get; set; }
        public string START_TIME { get; set; }
        public  string STOP_TIME { get; set; }
        public string SPACECRAFT_CLOCK_PARTITION { get; set; }
        public string NAC_SPACECRAFT_CLOCK_PREROLL_COUNT { get; set; }
        public string SPACECRAFT_CLOCK_START_COUNT { get; set; }
        public string  SPACECRAFT_CLOCK_STOP_COUNT { get; set; }
        public int START_SCLK_SECONDS { get; set; }
        public int START_SCLK_TICKS { get; set; }
        public int STOP_SCLK_SECONDS { get; set; }
        public int STOP_SCLK_TICKS { get; set; }
        public decimal NAC_LINE_EXPOSURE_DURATION { get; set; }
        public decimal WAC_EXPOSURE_DURATION { get; set; }
        public string NAC_FRAME_ID { get; set; }
        public int NAC_DAC_RESET { get; set; } 
        public int NAC_CHANNEL_A_OFFSET { get; set; }
        public int NAC_CHANNEL_B_OFFSET { get; set; }
        public int INSTRUMENT_MODE_CODE { get; set; }
        public string  WAC_INSTRUMENT_MODE_ID { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        


    }
}