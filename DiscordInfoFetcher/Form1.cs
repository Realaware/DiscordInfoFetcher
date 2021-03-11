using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace DiscordInfoFetcher
{
    public partial class Discord : Form
    {
        public Discord()
        {
            InitializeComponent();
        }

        private async Task<string> GetUserData(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync($"https://frihubv2.000webhostapp.com/GetDiscord.php?id={id}"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string Data = await content.ReadAsStringAsync();
                        return Data;
                    }
                }
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string LOL = await GetUserData("650698339792322560");
            dynamic Jsondata = JsonConvert.DeserializeObject(LOL);

            Console.WriteLine(Jsondata);

            this.Text = $"Made By {Jsondata.NameWithdis}";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string id = this.id.Text;
            if (Int64.TryParse(id,out _) == true)
            {
                string LOL = await GetUserData(id);
                dynamic Jsondata = JsonConvert.DeserializeObject(LOL);

                if (Jsondata.message == "Unknown User")
                {
                    MessageBox.Show("Unknown User", "suck error");
                    return;
                }

                this.rid.Text = "id: " + id;
                this.rname.Text = "name: " + Jsondata.name;
                this.ravatar.Text = "avatar: " + Jsondata.avatar;
                this.rdisname.Text = "nameWtdis: " + Jsondata.NameWithdis;
            } else {
                MessageBox.Show("sh it man just write only number lol", "suck error");
            }
        }
    }
}
