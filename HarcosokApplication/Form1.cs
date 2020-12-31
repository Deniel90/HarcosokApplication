using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HarcosokApplication
{
    public partial class HarcosForm : Form
    {
        static MySqlConnection kapcs;
        static MySqlCommand parancs;
        static int harcosID;

        public HarcosForm()
        {
            InitializeComponent();
        }

        private void HarcosForm_Load(object sender, EventArgs e)
        {
            MySqlBaseConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "cs_harcosok";
            sb.CharacterSet = "utf8";
            kapcs = new MySqlConnection(sb.ToString());

            try
            {
                kapcs.Open();
                parancs = kapcs.CreateCommand();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                kapcs.Close();
                Environment.Exit(0);
            }

            parancs = kapcs.CreateCommand();
            parancs.CommandText = @"CREATE TABLE IF NOT EXISTS harcosok(
                                    id INT PRIMARY KEY AUTO_INCREMENT,
                                    nev VARCHAR(100) UNIQUE,
                                    letrehozas DATE
                                    );

                                    CREATE TABLE IF NOT EXISTS kepessegek(
                                    id INT PRIMARY KEY AUTO_INCREMENT,
                                    nev VARCHAR(100),
                                    leiras VARCHAR(500),
                                    harcos_id INT,
                                    FOREIGN KEY (harcos_id) REFERENCES harcosok(id)
                                    );";

            parancs.ExecuteNonQuery();

            HarcosListaFrissit();
        }

        private void ButtonHarcosLetrehoz_Click(object sender, EventArgs e)
        {
            string nev = textBoxHarcosNev.Text.Trim();
            if (string.IsNullOrWhiteSpace(nev))
            {
                MessageBox.Show("Név megadása kötelező!");
                return;
            }

            parancs.CommandText = @"INSERT INTO harcosok(nev, letrehozas)
                                VALUES (@nev, @datum)";

            parancs.Parameters.AddWithValue("@nev", nev);
            parancs.Parameters.AddWithValue("@datum", DateTime.Now);

            try
            {
                if (parancs.ExecuteNonQuery() == 1)
                {
                    textBoxHarcosNev.Clear();
                    HarcosListaFrissit();
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ilyen nevű harcos már létezik!");
            }
            parancs.Parameters.Clear();
        }

        private void ButtonKepessegHozzaad_Click(object sender, EventArgs e)
        {
            if (comboBoxHarcosok.SelectedIndex < 0)
            {
                MessageBox.Show("Ki kell választani egy harcost!");
                return;
            }
            string kepesseg = textBoxKepessegNev.Text.Trim();
            if (string.IsNullOrWhiteSpace(kepesseg))
            {
                MessageBox.Show("Meg kell adni a képesség nevét!");
                return;
            }
            string leiras = textBoxLeiras.Text.Trim();
            if (string.IsNullOrWhiteSpace(leiras))
            {
                MessageBox.Show("Képesség felvételéhez szükséges legalább egy minimális leírás!!");
                return;
            }

            parancs.CommandText = @"INSERT INTO kepessegek (nev, leiras, harcos_id)
                                    VALUES (@kepesseg, @leiras, @id)";

            parancs.Parameters.AddWithValue("@kepesseg", kepesseg);
            parancs.Parameters.AddWithValue("@leiras", leiras);
            parancs.Parameters.AddWithValue("@id", harcosID);

            try
            {
                if (parancs.ExecuteNonQuery() == 1)
                {
                    textBoxKepessegNev.Clear();
                    textBoxLeiras.Clear();
                    HarcosListaFrissit();
                    KepessegListaFrissit();
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Nem sikerült az új képesség felvétele.");
            }
            parancs.Parameters.Clear();
        }

        private void ComboBoxHarcosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            parancs.CommandText = @"SELECT id 
                                    FROM harcosok 
                                    WHERE nev = @nev";
            parancs.Parameters.AddWithValue("@nev", comboBoxHarcosok.Text);

            using (MySqlDataReader olvaso = parancs.ExecuteReader())
            {
                while (olvaso.Read())
                {
                    harcosID = olvaso.GetInt32(0);
                }
            }
            parancs.Parameters.Clear();
        }

        private void ListBoxHarcosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Harcos)listBoxHarcosok.SelectedItem).Id;

            listBoxKepessegek.Items.Clear();
            textBoxKepessegLeiras.Clear();

            parancs.CommandText = @"SELECT id, nev, leiras, harcos_id 
                                    FROM kepessegek 
                                    WHERE harcos_id = @id";
            parancs.Parameters.AddWithValue("@id", id);

            using (MySqlDataReader olvaso = parancs.ExecuteReader())
            {
                while (olvaso.Read())
                {
                    listBoxKepessegek.Items.Add(new Kepesseg(olvaso.GetInt32(0), olvaso.GetString(1), olvaso.GetString(2), olvaso.GetInt32(3)));
                }
            }
            parancs.Parameters.Clear();
        }

        private void ListBoxKepessegek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxKepessegek.SelectedIndex < 0)
            {
                return;
            }

            int id = ((Kepesseg)listBoxKepessegek.SelectedItem).Id;

            parancs.CommandText = @"SELECT leiras 
                                    FROM kepessegek 
                                    WHERE id = @id";
            parancs.Parameters.AddWithValue("@id", id);

            using (MySqlDataReader olvaso = parancs.ExecuteReader())
            {
                while (olvaso.Read())
                {
                    textBoxKepessegLeiras.Text = olvaso.GetString(0);
                }
            }
            parancs.Parameters.Clear();
        }

        private void HarcosListaFrissit()
        {
            listBoxHarcosok.Items.Clear();
            comboBoxHarcosok.Items.Clear();

            parancs.CommandText = "SELECT id, nev, letrehozas FROM harcosok";
            parancs.ExecuteNonQuery();

            using (MySqlDataReader olvaso = parancs.ExecuteReader())
            {
                while (olvaso.Read())
                {
                    listBoxHarcosok.Items.Add(new Harcos(olvaso.GetInt32(0), olvaso.GetString(1), olvaso.GetDateTime(2)));
                    comboBoxHarcosok.Items.Add(olvaso.GetString(1));
                }
            }
        }
        private void KepessegListaFrissit()
        {
            if (listBoxHarcosok.SelectedIndex < 0)
            {
                return;
            }

            listBoxKepessegek.Items.Clear();

            parancs.CommandText = "SELECT id, nev, leiras, harcos_id FROM kepessegek";
            parancs.ExecuteNonQuery();

            using (MySqlDataReader olvaso = parancs.ExecuteReader())
            {
                while (olvaso.Read())
                {
                    listBoxKepessegek.Items.Add(new Kepesseg(olvaso.GetInt32(0), olvaso.GetString(1), olvaso.GetString(2), olvaso.GetInt32(3)));
                }
            }
        }

        private void ButtonKepessegTorles_Click(object sender, EventArgs e)
        {
            if (listBoxKepessegek.SelectedIndex < 0)
            {
                MessageBox.Show("Törléshez előbb ki kell választani egy képességet.");
                return;
            }

            int id = ((Kepesseg)listBoxKepessegek.SelectedItem).Id;

            parancs.CommandText = "DELETE FROM kepessegek WHERE id = @id";
            parancs.Parameters.AddWithValue("@id", id);

            parancs.ExecuteNonQuery();
            parancs.Parameters.Clear();
            listBoxKepessegek.Items.Clear();
            textBoxKepessegLeiras.Clear();
        }

        private void ButtonLeirasModosit_Click(object sender, EventArgs e)
        {
            if (listBoxKepessegek.SelectedIndex < 0)
            {
                MessageBox.Show("Módosításhoz előbb ki kell választani egy képességet.");
                return;
            }

            int id = ((Kepesseg)listBoxKepessegek.SelectedItem).Id;

            parancs.CommandText = "UPDATE kepessegek SET leiras = @leiras WHERE id = @id";
            parancs.Parameters.AddWithValue("@leiras", textBoxKepessegLeiras.Text);
            parancs.Parameters.AddWithValue("@id", id);

            parancs.ExecuteNonQuery();
            parancs.Parameters.Clear();
        }
    }
}
