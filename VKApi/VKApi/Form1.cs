using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using VKApi.VK;

namespace VKApi
{
    public partial class Form1 : Form
    {
        private readonly HttpClient client;
        private readonly string ACCESS_TOKEN = "ea5fdfe8ea5fdfe8ea5fdfe8baea236b27eea5fea5fdfe888d761176e1ca69c65885c2a";
        private readonly string vkVersion = "5.131";
        private string method = "groups.getById";

        public Form1()
        {
            InitializeComponent();
            txtId.Text = "eviko_coc";
            client = new HttpClient();
        }

        async void FetchUserInfo()
        {
            HttpResponseMessage response = await client.GetAsync($@"https://api.vk.com/method/{method}?group_ids={txtId.Text}&access_token={ACCESS_TOKEN}&v={vkVersion}");
            var content = await response.Content.ReadAsStringAsync();

            var group = JsonSerializer.Deserialize<VKResponse<VKGroup>>(content);
            txtResponse.Text = group.ToString();
        }

        public string PrettyJson(string unPrettyJson)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(unPrettyJson);

            return JsonSerializer.Serialize(jsonElement, options);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text != null)
            {
                btnMakeRequest.Enabled = true;
            }
        }

        private void btnMakeRequest_Click(object sender, EventArgs e)
        {
            FetchUserInfo();
            txtResponse.Text = "Гружу...";
        }
    }
}
