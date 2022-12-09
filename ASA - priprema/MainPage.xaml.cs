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

}

