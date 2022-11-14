using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Web.Script.Serialization;

namespace OvenMediaEngineKeyGen
{
    public class SignedPolicyUrlGenerator
    {
        static readonly char[] padding = { '=' };
        public string base_url { get; set; }
        public string stream_key { get; set; }
        public string secret_key { get; set; }

        public SignedPolicyUrlGenerator(string baseUrl, string streamKey, string secretKey)
        {
            base_url = baseUrl;
            stream_key = streamKey;
            secret_key = secretKey;
        }
        private string make_digest(string message)
        {
            using (var hmacsha1 = new HMACSHA1(Encoding.UTF8.GetBytes(secret_key)))
            {
                var hash = hmacsha1.ComputeHash(Encoding.UTF8.GetBytes(message));
                return Convert.ToBase64String(hash)
                    .TrimEnd(padding).Replace('+', '-').Replace('/', '_');
            }
        }
        public string generate(Dictionary<string, object> param)
        {
            string policy_json = new JavaScriptSerializer().Serialize(param);

            var policy_base64 = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(policy_json)).TrimEnd(padding).Replace('+', '-').Replace('/', '_');

            System.Console.WriteLine(policy_json);

            var stream_url = string.Format("{0}{1}?policy={2}", base_url, stream_key, policy_base64);
            var sig = make_digest(stream_url);

            return string.Format("{0}&signature={1}", stream_url, sig);
        }

        public string generateWebRTC(Dictionary<string, object> param)
        {
            string policy_json = new JavaScriptSerializer().Serialize(param);

            var policy_base64 = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(policy_json)).TrimEnd(padding).Replace('+', '-').Replace('/', '_');

            System.Console.WriteLine(policy_json);

            var stream_url = string.Format("{0}{1}?policy={2}", base_url, stream_key, policy_base64);
            var sig = make_digest(stream_url);

            return string.Format("{0}&signature={1}&direction=send", stream_url, sig);
        }

        private string DecodeBase64(string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;
            var valueBytes = System.Convert.FromBase64String(value);
            return System.Text.Encoding.UTF8.GetString(valueBytes);
        }
    }
}
