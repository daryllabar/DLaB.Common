#if DLAB_UNROOT_COMMON_NAMESPACE
using DLaB.Common.Exceptions;
// ReSharper disable CanSimplifyDictionaryTryGetValueWithGetValueOrDefault

namespace DLaB.Common
#else

using Source.DLaB.Common.Exceptions;

namespace Source.DLaB.Common
#endif
{

    public class ToCsvOptions
    {
        public bool SkipNullValues { get; set; } = true;
        public bool SkipEmptyStrings { get; set; } = true;
        public string? DefaultValue { get; set; }
    }

}
