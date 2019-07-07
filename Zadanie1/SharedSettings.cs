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

        // Zadanie 3
        public static int FilterM { get; set; } = 50;
        public static double FilterF0 { get; set; } = 10.0;
        public static double FilterFp { get; set; } = 70.0;
        public static string ChosenWindow { get; set; } = "prostokątne";
        // Zadanie 3 antena
        public static int NumberOfMeasurement { get; set; } = 10;
        public static double TimeUnit { get; set; } = 10;
        public static double RealSpeed { get; set; } = 10;
        public static double AbstractSpeed { get; set; } = 2000;
        public static double SignalPeriod { get; set; } = 1;
        public static int BasicSignals { get; set; } = 2;
        public static double BuffersLength { get; set; } = 400;
        public static double ReportingPeriod { get; set; } = 2;
        public static double SamplingFrequency { get; set; } = 100;
    }
}
