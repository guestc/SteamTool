using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace SteamTool.utils
{
    class JConfig
    {
        private string Path = null;

        public JConfig(string path) {
            this.Path = path;
            init();
        }

        public void init() {
            if (!File.Exists(Path)) {
                File.Create(Path);
            }
        }

        public string get(string key) {
            FileStream fs = File.OpenRead(Path);
            StringBuilder sb = new StringBuilder();
            int code = 0;
            do {
                byte[] bt = new byte[fs.Length > 1024 ? 1024 : fs.Length];
                code = fs.Read(bt, 0, bt.Length);
                sb.Append(UTF8Encoding.UTF8.GetString(bt));
            } while (code == 1024);
            fs.Close();

            JObject data =(JObject) JsonConvert.DeserializeObject(sb.ToString());
            if (data == null) return null;
            JToken oj = null;
            return data.TryGetValue(key,out oj) ? oj.ToString() : null;
            
        }

        public void set(string key, string value) {
            FileStream fs = File.OpenWrite(Path);
            JObject data = new JObject();
           // JToken jt = JToken.Parse(value);
            data.Add(key,value); 
            string all = JsonConvert.SerializeObject(data);
            byte[] b = UTF8Encoding.UTF8.GetBytes(all);
            fs.Write(b,0,b.Length);
            fs.Close();
        }
    }
}
