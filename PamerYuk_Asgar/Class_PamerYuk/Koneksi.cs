using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_PamerYuk
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        public MySqlConnection KoneksiDB { get => koneksiDB; set => koneksiDB = value; }
        public Koneksi()
        {
            // Buka konfigurasi App.Config
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Ambil section userSettings yang otomatis dibuat berdasarkan file .settings
            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            // Ambil bagian setting SistemPenjualanPembelian.db
            var settingsSection = userSettings.Sections["PamerYuk_Asgar.db"] as ClientSettingsSection;

            // Ambil tiap variable setting
            string DbServer = settingsSection.Settings.Get("DbServer").Value.ValueXml.InnerText;
            string DbName = settingsSection.Settings.Get("DbName").Value.ValueXml.InnerText;
            string DbUsername = settingsSection.Settings.Get("DbUsername").Value.ValueXml.InnerText;
            string DbPassword = settingsSection.Settings.Get("DbPassword").Value.ValueXml.InnerText;

            string strCon = "server=" + DbServer + ";database=" + DbName + ";uid=" + DbUsername + ";password=" + DbPassword;
            koneksiDB = new MySqlConnection();
            koneksiDB.ConnectionString = strCon;
            Connect();
        }
        public Koneksi(string pS, string pD, string pU, string pP)
        {
            string conString = "Server=" + pS + ";Database=" + pD + ";Uid=" + pU + ";pwd=" + pP;
            koneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = conString;
            Connect();
        }
        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }
        public static MySqlDataReader JalankanPerintahSelect(string perintah)
        {
            Koneksi k = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(perintah, k.KoneksiDB);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public static int JalankanPerintahNonQuery(string perintah)
        {
            Koneksi koneksi = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(perintah, koneksi.KoneksiDB);
            int hasil = cmd.ExecuteNonQuery();
            return hasil;
        }
    }
}
