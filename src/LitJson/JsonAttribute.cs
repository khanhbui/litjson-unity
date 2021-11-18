using System;

namespace LitJson
{
    [AttributeUsage (AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class JsonIgnoreAttribute : Attribute
    {
    }

    [AttributeUsage (AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class JsonSerializeAttribute : Attribute
    {
        public JsonSerializeAttribute ()
        {
            Alias = null;
        }

        public JsonSerializeAttribute (string alias)
        {
            Alias = alias;
        }

        public readonly string Alias;
    }
}
