
// ReSharper disable once CheckNamespace
#pragma warning disable

namespace ExCSS
{
    public abstract class BaseSelector
    {
        public sealed override string ToString()
        {
            return ToString(false);
        }

        public abstract string ToString(bool friendlyFormat, int indentation = 0);
    }
}



#pragma warning restore