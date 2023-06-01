using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tugas_PBO_Winform
{
    public partial class Form_TokoLaptop : Form
    {
        public Form_TokoLaptop()
        {
            InitializeComponent();
        }

        private void Form_TokoLaptop_Load(object sender, EventArgs e)
        {
            showDataLaptop();
            showDataLaptop2();
            showDataTransaksi();
            showDataDetailTransaksi();
        }

        private void showDataLaptop2()
        {
            var reader = new DBHelpers().Select("Select * from laptop order by id_laptop");
            dataGridLaptop2.Rows.Clear();
            while (reader.Read())
            {
                dataGridLaptop2.Rows.Add(reader["id_laptop"], reader["nama_laptop"], reader["harga_laptop"], reader["stok"]);
            }
        }

        private void showDataDetailTransaksi()
        {
            var reader2 = new DBHelpers().Select("Select * from detail_transaksi order by id_detail_transaksi");
            dataGridDetailTransaksi.Rows.Clear();
            while (reader2.Read())
            {
                dataGridDetailTransaksi.Rows.Add(reader2["id_detail_transaksi"], reader2["id_transaksi"], reader2["id_laptop"], reader2["stok_dibeli"]);
            }
        }

        private void showDataTransaksi()
        {
            var reader3 = new DBHelpers().Select("Select * from transaksi order by id_transaksi");
            dataGridTransaksi.Rows.Clear();
            while (reader3.Read())
            {
                dataGridTransaksi.Rows.Add(reader3["id_transaksi"], reader3["tanggal_transaksi"], reader3["status_transaksi"]);
            }
        }

        private void showDataLaptop()
        {
            var reader = new DBHelpers().Select("Select * from laptop order by id_laptop");
            dataGridLaptop.Rows.Clear();
            while (reader.Read())
            {
                dataGridLaptop.Rows.Add(reader["id_laptop"], reader["nama_laptop"], reader["harga_laptop"], reader["stok"]);
            }
        }

        private void bt_Insert_detail_Click(object sender, EventArgs e)
        {
            var check = new DBHelpers().Select($"SELECT * FROM transaksi ORDER BY id_transaksi DESC LIMIT 1");
            if (!check.Read())
            {
                string sql = $"INSERT INTO transaksi(id_transaksi, status_transaksi) VALUES ({tb_IDTransaksi.Text}, 'Diproses')";
                new DBHelpers().Execute(sql);
                new DBHelpers().Execute($"INSERT INTO detail_transaksi(id_transaksi, id_laptop, stok_dibeli) VALUES ({tb_IDTransaksi.Text},{tb_IDLaptop.Text},{tb_JumlahBarang.Text})");
                new DBHelpers().Execute($"UPDATE laptop SET stok = stok - ({tb_JumlahBarang.Text}) WHERE id_laptop = {tb_IDLaptop.Text}");
                showDataLaptop();
                showDataLaptop2();
                showDataTransaksi();
                showDataDetailTransaksi();
            }
            else
            {

                var statusTransaksi = check.GetValue(2).ToString();
                if (statusTransaksi == "Diproses")
                {
                    new DBHelpers().Execute($"INSERT INTO detail_transaksi(id_transaksi, id_laptop, stok_dibeli) VALUES ({tb_IDTransaksi.Text},{tb_IDLaptop.Text},{tb_JumlahBarang.Text})");
                    new DBHelpers().Execute($"UPDATE laptop SET stok = stok - ({tb_JumlahBarang}) WHERE id_laptop = {tb_IDLaptop.Text}");
                    showDataLaptop();
                    showDataLaptop2();
                    showDataTransaksi();
                    showDataDetailTransaksi();
                }
                else
                {
                    string sql = $"INSERT INTO transaksi(id_transaksi, status_transaksi) VALUES ({tb_IDTransaksi.Text}, 'Diproses')";
                    new DBHelpers().Execute(sql);
                    new DBHelpers().Execute($"INSERT INTO detail_transaksi(id_transaksi, id_laptop, stok_dibeli) VALUES ({tb_IDTransaksi.Text},{tb_IDLaptop.Text},{tb_JumlahBarang.Text})");
                    new DBHelpers().Execute($"UPDATE laptop SET stok = stok - ({tb_JumlahBarang}) WHERE id_laptop =  {tb_IDLaptop.Text}");
                    showDataLaptop();
                    showDataLaptop2();
                    showDataTransaksi();
                    showDataDetailTransaksi();
                }

            }
        }

        private void bt_Insert_Laptop_Click(object sender, EventArgs e)
        {
            new DBHelpers().Execute($"INSERT INTO LAPTOP(nama_laptop, harga_laptop, stok) VALUES ('{tb_NamaLaptop.Text}','{tb_HargaLaptop.Text}','{tb_StokLaptop.Text}')");
            showDataLaptop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var reader = new DBHelpers().Select($"select * from laptop where nama_laptop ilike '%{tb_Search.Text}%'");
            dataGridLaptop.Rows.Clear();
            while (reader.Read())
            {
                dataGridLaptop.Rows.Add(reader["id_laptop"], reader["nama_laptop"], reader["harga_laptop"], reader["stok"]);
            }
        }

        private void bt_UpdateLaptop_Click(object sender, EventArgs e)
        {
            UpdateLaptop form = new UpdateLaptop();
            form.ShowDialog();
            showDataLaptop();
            showDataLaptop2();
        }

        private void bt_DeleteLaptop_Click(object sender, EventArgs e)
        {
            DeleteLapop form2 = new DeleteLapop();
            form2.ShowDialog();
            showDataLaptop();
            showDataLaptop2();
        }

        private void bt_selesai_Click(object sender, EventArgs e)
        {
            new DBHelpers().Execute($"UPDATE transaksi SET status_transaksi = 'Selesai' where id_transaksi = (SELECT id_transaksi FROM transaksi ORDER BY id_transaksi DESC LIMIT 1)");
            showDataLaptop();
            showDataLaptop2();
            showDataTransaksi();
            showDataDetailTransaksi();
        }
        string APIKey = "56dda655da157bc469b3c31722e55383";
        private void bt_search_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format($"https://api.openweathermap.org/data/2.5/weather?q={tb_city.Text}&units=metric&appid={APIKey}");
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                weatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                lab_Condition.Text = Info.weather[0].main;
                lab_Detail.Text = Info.weather[0].description;
                lab_Sunrise.Text = convertDateTime(Info.sys.sunrise).ToString();
                lab_Sunset.Text = convertDateTime(Info.sys.sunset).ToString();
                lab_Pressure.Text = Info.main.pressure.ToString();
                lab_Temp.Text = Info.main.temp.ToString();
                lab_Windspeed.Text = Info.wind.speed.ToString();
            }
        }

        private object convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }
    }
}
