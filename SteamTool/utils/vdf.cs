using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Gameloop.Vdf;
using Gameloop.Vdf.Linq;
namespace SteamTool.utils
{

    class Vdf
    {
        private string Path = null;

        public Vdf(string path)
        {
            this.Path = path;
            init();
        }

        public void init()
        {
            if (!File.Exists(Path))
            {
                File.Create(Path);
            }
        }

        public Dictionary<string, SteamUserInfo> get()
        {
            FileStream fs = File.OpenRead(Path);
            StringBuilder sb = new StringBuilder();
            int code = 0;
            do
            {
                byte[] bt = new byte[fs.Length > 1024 ? 1024 : fs.Length];
                code = fs.Read(bt, 0, bt.Length);
                sb.Append(UTF8Encoding.UTF8.GetString(bt));
            } while (code == 1024);
            fs.Close();
            VProperty v = VdfConvert.Deserialize(sb.ToString());
            VToken[] keys = v.Value.ToArray<VToken>();
            Dictionary<string, SteamUserInfo> list = new Dictionary<string, SteamUserInfo>();
            foreach (VToken vt in keys) {
                dynamic data = vt;
                SteamUserInfo user = new SteamUserInfo();
                user.user = data.Value.AccountName.ToString();
                user.id64 = data.Key;
                user.name = data.Value.PersonaName.ToString();
                list.Add(data.Key, user);
            }
            return list;
        }

    }
}
