using System.Security.Cryptography.X509Certificates;
using static Pizzeria_Koe3.Form1;

namespace Pizzeria_Koe3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        public class Pizza
        {
            // Luokka Pizza, joka tallentaa pizzan nimen, hinnan, lis‰t‰ytteiden m‰‰r‰n ja kappalem‰‰r‰n
            public string Nimi { get; set; }
            public double Hinta { get; set; }
            public int LisaTaytteet { get; set; }
            public int Maara { get; set; }

            //asetetaan pizzan nimi, hinta, lis‰t‰ytteiden m‰‰r‰ ja kappalem‰‰r‰
            public Pizza(string nimi, double hinta, int LisaTaytteet = 0, int maara = 0)
            {
                Nimi = nimi;
                Hinta = hinta;
                LisaTaytteet = 0;
                Maara = maara;
            }
        }
        public class Juomat
        {
            public string Koko { get; set; }
            public double Hinta { get; set; }
            public Juomat(string koko, double hinta)
            {
                Koko = koko;
                Hinta = hinta;
            }
        }

        List<Pizza> Pizzat = new List<Pizza> //Lista mik‰ tallentaa pizzat
    {
        new Pizza("Pizza1", 8.5),
        new Pizza("Pizza2", 9.0),
        new Pizza("Pizza3", 10.5),
        new Pizza("Pizza4", 9.5),
        new Pizza("Pizza5", 11.0),
        new Pizza("Pizza6", 11.6),
        new Pizza("Pizza7", 8.0),
        new Pizza("Pizza8", 13.0),
        new Pizza("Pizza9", 11.5),
        new Pizza("Pizza10",15.0)
    };

        List<Juomat> juomat = new List<Juomat> //Lista joka tallentaa juomat
        {
            new Juomat("Kokis 0.5l", 2.0),
            new Juomat("Kokis 1.5l", 3.5)
        };


        public void btnOK_Click(object sender, EventArgs e)
        {

            double Yhteenlaskettu = 0; //Alustettu muuttuja
            int PizzaLaskuri = 0; //Alustetaan muuttuja

            //Tyhjent‰‰ aiemmat tulokset listboksista
            listboxPizza.Items.Clear();

            //Lasketaan valitut pizzat ja niiden hinnat

            foreach (var pizza in Pizzat)
            {
                // Tarkistetaan onko valittu pizza listassa.
                if (cmbValitsePizza.SelectedIndex != null && cmbValitsePizza.SelectedItem.ToString().Contains(pizza.Nimi))
                {
                    int pizzaMaara = (int)numPizzaMaara.Value; //Haetaan k‰ytt‰j‰n valitsema m‰‰r‰ numero komponentista.
                    int LisaTaytteet = (int)numTayte.Value; //Haetaan k‰ytt‰j‰n valitsema m‰‰r‰ numero komponentista.
                    //Lasketaan pizzan kustannukset lis‰t‰ytteiden ja m‰‰r‰n kanssa
                    double PizzaKustannus = (pizza.Hinta + (LisaTaytteet * 0.5)) * pizzaMaara; 
                    Yhteenlaskettu += PizzaKustannus; //T‰m‰ lis‰‰ pizzankustannukset osaksi kokonais kustannuksia
                    PizzaLaskuri += pizzaMaara; // P‰ivitet‰‰n tilattujen pizzojen m‰‰r‰

                    //Lis‰t‰‰n pizzan tiedot listboxiin.
                    listboxPizza.Items.Add($"Pizza: {pizza.Nimi} - {pizza.Hinta}Ä x {pizzaMaara}, {LisaTaytteet} lis‰t‰ytteet");

                }

            }

            //Lasketaan valitut Juomat ja niiden hinnat

            foreach (var juoma in juomat)
            {
                //Tarkistaa onko valittua juomaa listassa
                if (cmbJuoma.SelectedIndex != null && cmbJuoma.SelectedItem.ToString().Contains(juoma.Koko))
                {
                    Yhteenlaskettu += juoma.Hinta; //Lis‰‰ juoman hinnan kokonaishintaan.

                    //Lis‰‰ juoman tiedot listboxiin
                    listboxPizza.Items.Add($"Juoma: {juoma.Koko} - {juoma.Hinta}Ä ");
                }
            }
            //Tarkistaa checkboxin avulla, ett‰ onko alennus k‰ytˆss‰.
            if (checkBoxAlennus.Checked)
            {
                Yhteenlaskettu = LaskettuAlennus(PizzaLaskuri, Yhteenlaskettu); //Tarvittaessa laskee alennuksen ja p‰ivitt‰‰ kokonaiskustannukset.
            }

            //N‰ytt‰‰ tuotteiden yhteenlasketun summan.
            listboxPizza.Items.Add($"Kokonaiskustannukset: {Yhteenlaskettu} Ä");
             // P‰ivitet‰‰n kassa
             KassaSysteemi(Yhteenlaskettu);
        }


              public void KassaSysteemi(double summa) //funktio, joka p‰ivitt‰‰ kassaan kertyneen raham‰‰r‰n aina, kun uusi tilaus maksetaan.
        { 
            YhteensaRahaaKassassa += summa;
            lblKassa.Text = "Kassassa: " + YhteensaRahaaKassassa.ToString("C");
        }
        

    

        



        private double LaskettuAlennus(int PizzaLaskuri, double Yhteenlaskettu)
        {
            //Laskee alennuksen 
            int AlennusPizzasta = PizzaLaskuri / 6; //Jakaa pizzalaskurin kuudella
            double alennus = AlennusPizzasta * (Yhteenlaskettu / PizzaLaskuri) * 0.5; 
            return Yhteenlaskettu - alennus;
        }



        private bool HintojenMuuttaminen = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!HintojenMuuttaminen)
            {
                //Ottaa k‰ytt‰‰n hintojen muuttamisen
                HintojenMuuttaminen = true;
                MessageBox.Show("Voit nyt muuttaa hintoja");
            }
            else if (cmbValitsePizza.SelectedIndex != -1)
            {
                string PizzaNimi = cmbValitsePizza.SelectedItem.ToString(); //Hakee valitun pizzan nimen
                double Uusihinta;

                if (double.TryParse(txtUusiHinta.Text, out Uusihinta))
                {
                    var pizza = Pizzat.FirstOrDefault(p => p.Nimi == PizzaNimi); //Etsii valitun pizzan
                    if (pizza != null)
                    {
                        pizza.Hinta = Uusihinta; //P‰ivitt‰‰ pizzan hinnan
                        MessageBox.Show($"Pizzan {PizzaNimi} uusi hinta on {Uusihinta}");
                        HintojenMuuttaminen = false; //Poistaa oikeuden muuttaa hintoja


                    }
                }
            }

        }
        public double YhteensaRahaaKassassa = 0; //M‰‰rritelty muuttuja, joka seuraa kassaan kertynytt‰ rahaa.

        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            listboxPizza.Items.Clear(); //Tyhjenn‰ nappia painaessa listbox tyhjentyy.
            
            
        }
    }
}
