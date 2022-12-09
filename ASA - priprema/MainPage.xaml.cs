using ASA___priprema.Models;

namespace ASA___priprema;

public partial class MainPage : ContentPage
{
	List<VrstaOsiguranja> listaVrstaOsiguranja;
	List<KlasaOsiguranja> listaKlasaOsiguranja;

	public MainPage()
	{
		listaVrstaOsiguranja = new List<VrstaOsiguranja>
		{
			new VrstaOsiguranja{ id = 1, naziv = "PUTNO \nOSIGURANJE", osiguranaSumaPoUsluzi = 2500, cijena = 2, icon = "putnozdravstvenoosiguranje.png",ugovorena = false },
            new VrstaOsiguranja{ id = 2, naziv = "OSIGURANJE \nSTANA", osiguranaSumaPoUsluzi = 4300, cijena = 4,icon = "osiguranjestana.png", ugovorena = false },
            new VrstaOsiguranja{ id = 3, naziv = "ZDRAVSTVENO \nOSIGURANJE", osiguranaSumaPoUsluzi = 5100, cijena = 5, icon = "dobrovoljnozdravstvenoosiguranje.png", ugovorena = false },
            new VrstaOsiguranja{ id = 4, naziv = "ASISTENCIJA \nNA PUTU", osiguranaSumaPoUsluzi = 900, cijena = 50, icon = "pomocnacesti.png", ugovorena = false },
            new VrstaOsiguranja{ id = 5, naziv = "MALI \nKASKO", osiguranaSumaPoUsluzi = 12000, cijena = 500, icon = "malikasko.png", ugovorena = false },
            new VrstaOsiguranja{ id = 6, naziv = "OSIGURANJE \nMOBITELA", osiguranaSumaPoUsluzi = 2500, cijena = 50, icon = "kaskoosiguranjemobilnihtelefona.png", ugovorena = false }
        };
		listaKlasaOsiguranja = new List<KlasaOsiguranja>
		{
			new KlasaOsiguranja{ id = 1, nazivKlase = "Osnovno", faktorOsiguraneSume = 1, faktorCijene = 1 },
			new KlasaOsiguranja{ id = 2, nazivKlase = "Plus", faktorOsiguraneSume = 2, faktorCijene = 3 },
			new KlasaOsiguranja{ id = 3, nazivKlase = "Premium", faktorOsiguraneSume = 3, faktorCijene = 5 }
		};

        InitializeComponent();

		osiguranje1Slika.Source = listaVrstaOsiguranja[0].icon;
		osiguranje1Checkbox.IsChecked = false;
		osiguranje1Naziv.Text = listaVrstaOsiguranja[0].naziv;

        osiguranje2Slika.Source = listaVrstaOsiguranja[1].icon;
        osiguranje2Checkbox.IsChecked = false;
        osiguranje2Naziv.Text = listaVrstaOsiguranja[1].naziv;

        osiguranje3Slika.Source = listaVrstaOsiguranja[2].icon;
        osiguranje3Checkbox.IsChecked = false;
        osiguranje3Naziv.Text = listaVrstaOsiguranja[2].naziv;

        osiguranje4Slika.Source = listaVrstaOsiguranja[3].icon;
        osiguranje4Checkbox.IsChecked = false;
        osiguranje4Naziv.Text = listaVrstaOsiguranja[3].naziv;

        osiguranje5Slika.Source = listaVrstaOsiguranja[4].icon;
        osiguranje5Checkbox.IsChecked = false;
        osiguranje5Naziv.Text = listaVrstaOsiguranja[4].naziv;

        osiguranje6Slika.Source = listaVrstaOsiguranja[5].icon;
        osiguranje6Checkbox.IsChecked = false;
        osiguranje6Naziv.Text = listaVrstaOsiguranja[5].naziv;

        klasaPicker.ItemsSource = listaKlasaOsiguranja;

    }

    private void kalkulacija(object o, EventArgs e)
    {
        bool osi1 = osiguranje1Checkbox.IsChecked;
        bool osi2 = osiguranje2Checkbox.IsChecked;
        bool osi3 = osiguranje3Checkbox.IsChecked;
        bool osi4 = osiguranje4Checkbox.IsChecked;
        bool osi5 = osiguranje5Checkbox.IsChecked;
        bool osi6 = osiguranje6Checkbox.IsChecked;

        int osi1Kolicina, osi2Kolicina, osi3Kolicina, osi4Kolicina, osi5Kolicina, osi6Kolicina;

        int.TryParse(osiguranje1Kolicina.Text, out osi1Kolicina);
        int.TryParse(osiguranje2Kolicina.Text, out osi2Kolicina);
        int.TryParse(osiguranje3Kolicina.Text, out osi3Kolicina);
        int.TryParse(osiguranje4Kolicina.Text, out osi4Kolicina);
        int.TryParse(osiguranje5Kolicina.Text, out osi5Kolicina);
        int.TryParse(osiguranje6Kolicina.Text, out osi6Kolicina);

        double ukupnaCijena = 0;
        double osiguranaSuma = 0;

        int klasaIndex = klasaPicker.SelectedIndex;

        int klasaCijena = 0;
        int klasaOsiguraneSume = 0;

        if(klasaIndex >= 0)
        {
            klasaCijena = listaKlasaOsiguranja[klasaIndex].faktorCijene;
            klasaOsiguraneSume = listaKlasaOsiguranja[klasaIndex].faktorOsiguraneSume;
        }


        ukupnaCijena += (listaVrstaOsiguranja[0].cijena * osi1Kolicina) + (listaVrstaOsiguranja[1].cijena * osi2Kolicina) + (listaVrstaOsiguranja[2].cijena * osi3Kolicina) +
            (listaVrstaOsiguranja[3].cijena * osi4Kolicina) + (listaVrstaOsiguranja[4].cijena * osi5Kolicina) + (listaVrstaOsiguranja[5].cijena * osi6Kolicina) + klasaCijena;

        osiguranaSuma += (listaVrstaOsiguranja[0].osiguranaSumaPoUsluzi * osi1Kolicina) + (listaVrstaOsiguranja[1].osiguranaSumaPoUsluzi * osi2Kolicina) +
            (listaVrstaOsiguranja[2].osiguranaSumaPoUsluzi * osi3Kolicina) + (listaVrstaOsiguranja[3].osiguranaSumaPoUsluzi * osi4Kolicina) +
            (listaVrstaOsiguranja[4].osiguranaSumaPoUsluzi * osi5Kolicina) + (listaVrstaOsiguranja[5].osiguranaSumaPoUsluzi * osi6Kolicina) + klasaOsiguraneSume;

        bool porodicniPaket = switchPorodicno.IsToggled;

        if (porodicniPaket) ukupnaCijena *= 1.3;

        int brVrsta = 0;

        if (osi1) brVrsta++;
        if (osi2) brVrsta++;
        if (osi3) brVrsta++;
        if (osi4) brVrsta++;
        if (osi5) brVrsta++;
        if (osi6) brVrsta++;


        if (!osi1 && !osi2 && !osi3 && !osi4 && !osi5 && !osi6)
        {
            DisplayAlert("Greska", "Niste izabrali nijednu vrstu osiguranja", "Nazad");
        }else if( (osi1 && osi1Kolicina == 0) || (osi2 && osi2Kolicina == 0) || (osi3 && osi3Kolicina == 0) ||
            (osi4 && osi4Kolicina == 0) || (osi5 && osi5Kolicina == 0) || (osi6 && osi6Kolicina == 0))
        {
            DisplayAlert("Greska", "Niste unijeli količinu Za odabranu vrstu osiguranja", "Nazad");
        }else if(klasaIndex < 0)
        {
            DisplayAlert("Greska", "Niste unijeli klasu osiguranja", "Nazad");
        }
        else DisplayAlert("POLICA OSIGURANJA", 
            "Ukupna vrijednost osiguranja: " + ukupnaCijena.ToString() + " KM" +
            "\nBroj odabranih vrsta osiguranja: " + brVrsta + 
            "\nOsigurana suma: " + osiguranaSuma + " KM" + 
            "\nPorodični paket: " + porodicniPaket.ToString() + 
            "\nKlasa index: " + klasaIndex, 
            "Ok");

    }

}

