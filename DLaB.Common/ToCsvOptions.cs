namespace DLaB.Common
{

    public class ToCsvOptions
    {
        public bool SkipNullValues { get; set; } = true;
        public bool SkipEmptyStrings { get; set; } = true;
        public string? DefaultValue { get; set; }
    }

}
