using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kliens.MyBankService;

/// <summary>
/// Készítette: Lanszki Csaba
/// </summary>

namespace Kliens
{
    public partial class Form1 : Form
    {
        public static void EnableTab(TabPage page, bool enable)
        {
            EnableControls(page.Controls, enable);
        }
        private static void EnableControls(Control.ControlCollection ctls, bool enable)
        {
            foreach (Control ctl in ctls)
            {
                ctl.Enabled = enable;
                EnableControls(ctl.Controls, enable);
            }
        }

        BankClient client = new BankClient();
        string uid = null;

        public Form1()
        {
            InitializeComponent();
            kijelentkezesbutton.Enabled = false;
            label4.Visible = false;
            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 2], false);
            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 3], false);
            tabControl1.SelectedIndex = 0;
        }

        private void bejelentkezesbutton_Click(object sender, EventArgs e)
        {
            if (felhnevtextBox.Text == "")
            {
                MessageBox.Show("Üres a felhasználó név!");
                return;
            }
            else if (jelszotextBox.Text == "")
            {
                MessageBox.Show("Üres a jelszó!");
                return;
            }

            try
            {
                uid = client.Bejelentkezes(felhnevtextBox.Text, jelszotextBox.Text);

                if (uid == "0")
                {
                    MessageBox.Show("Rossz felhasználó név, vagy jelszó!", "Figyelem");
                    return;
                }
                else
                {
                    kijelentkezesbutton.Enabled = true;
                    label4.Visible = false;
                    EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 0], false);
                    EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], true);
                    EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 2], true);
                    EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 3], true);
                    tabControl1.SelectedIndex = 1;
                    felhnevtextBox.Clear();
                    jelszotextBox.Clear();
                }
            }
            catch (FaultException<Hiba> f)
            {
                MessageBox.Show(f.Detail.HibaTipusa, f.Detail.Muvelet, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Nem érhető el a szerver, kérjük próbálja meg később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void kijelentkezesbutton_Click(object sender, EventArgs e)
        {
            try
            {
                uid = client.Kijelentkezes(uid);
                kijelentkezesbutton.Enabled = false;
                label4.Visible = false;
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 0], true);
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 2], false);
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 3], false);
                tabControl1.SelectedIndex = 0;
            }
            catch (FaultException<Hiba> f)
            {
                MessageBox.Show(f.Detail.HibaTipusa, f.Detail.Muvelet, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Nem érhető el a szerver, kérjük próbálja meg később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lekerdezesbutton_Click(object sender, EventArgs e)
        {
            try
            {
                osszeglabel.Text = client.Lekerdezes(uid);
                label4.Visible = true;
            }
            catch (FaultException<Hiba> f)
            {
                MessageBox.Show(f.Detail.HibaTipusa, f.Detail.Muvelet, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Nem érhető el a szerver, kérjük próbálja meg később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void feltoltesbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (feltoltestextBox.Text == "")
                {
                    MessageBox.Show("Üres az összeg mező!");
                    return;
                }
                else if (Convert.ToInt32(feltoltestextBox.Text) <= 0)
                {
                    MessageBox.Show("Kérem pozitív értéket adjon meg!");
                    return;
                }

                osszeglabel.Text = client.Feltoltes(Convert.ToInt32(feltoltestextBox.Text), uid);
                label4.Visible = true;
                feltoltestextBox.Clear();
            }
            catch (FaultException<Hiba> f)
            {
                MessageBox.Show(f.Detail.HibaTipusa, f.Detail.Muvelet, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Nem érhető el a szerver, kérjük próbálja meg később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Kérjük pozitív szám értéket adjon meg!");
            }

        }

        private void utalasbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (kinektextBox.Text == "")
                {
                    MessageBox.Show("Üres a kezdeményezett mező!");
                    return;
                }
                else if (mennyittextBox.Text == "" || Convert.ToInt32(mennyittextBox.Text) <= 0)
                {
                    MessageBox.Show("Nem adott meg utalni kívánt összeget!");
                    return;
                }

                Utal utal = new Utal();

                utal = client.Utalas(kinektextBox.Text, int.Parse(mennyittextBox.Text), uid);
                if (utal.Eredmeny)
                {
                    utalasinfolabel.Text = "Sikeresen utalásra került a(z) " + mennyittextBox.Text + " Ft összeg, a " + kinektextBox.Text + " nevű felhasználónak.";
                }
                else
                {
                    utalasinfolabel.Text = "Nem került utalásra a(z) " + mennyittextBox.Text + " Ft összeg, a " + kinektextBox.Text + " nevű felhasználónak.";
                }
                kinektextBox.Clear();
                mennyittextBox.Clear();
            }
            catch (FaultException<Hiba> f)
            {
                MessageBox.Show(f.Detail.HibaTipusa, f.Detail.Muvelet, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Nem érhető el a szerver, kérjük próbálja meg később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Kérjük pozitív szám értéket adjon meg!");
            }
        }

        private void lekerdezbutton_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();

                List<Utalasok> u = client.UtalasokList(uid).ToList();

                for (int i = 0; i < u.Count; i++)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { u[i].Nev, u[i].Ido.ToString(), u[i].Osszeg.ToString() }));
                }
            }
            catch (FaultException<Hiba> f)
            {
                MessageBox.Show(f.Detail.HibaTipusa, f.Detail.Muvelet, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Nem érhető el a szerver, kérjük próbálja meg később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
