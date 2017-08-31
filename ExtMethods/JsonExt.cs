using Newtonsoft.Json;

namespace ExtMethods
{
    public static class JsonExt
    {
        public static string ToJson(this object data)
        {
            return JsonConvert.SerializeObject(data);
        }
    }
}