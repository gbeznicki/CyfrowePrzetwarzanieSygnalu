namespace Zadanie1
{
    public static class SharedSettings
    {
        public static double Amplitude { get; set; } = 10;
        public static double Period { get; set; } = 5;
        public static double InitialTime { get; set; } = 0;
        public static double ImpletionRate { get; set; } = 0.7;
        public static double JumpTime { get; set; } = 6;
        public static double Probability { get; set; } = 0.1;
        public static double Frequency { get; set; } = 5000;
        public static double TotalTime { get; set; } = 10;
        public static int RangesAmount { get; set; } = 10;

        // zadanie 2
        public static int SamplingFrequencyAc { get; set; } = 20;
        public static int ReconstructionFrequency { get; set; } = 15;
        public static int QuantizationLevel { get; set; } = 4;
        public static int ConsideredSamplesNumber { get; set; } = 4;
    }
}
