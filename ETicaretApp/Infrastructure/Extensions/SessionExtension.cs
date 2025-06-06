using System.Text.Json;

namespace ETicaretApp.Infrastructure.Extensions
{
    public static class SessionsExtension 
    {
        public static void SetJson(this ISession session, string key, string value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static void SetJson<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T? GetJson<T>(this ISession session, string key)
        {
            var data = session.GetString(key);
            return data is null ? default(T) : JsonSerializer.Deserialize<T>(data);
        }
    }
}