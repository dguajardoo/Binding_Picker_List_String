using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;

namespace qwertyui
{
    public partial class MainPage : ContentPage
    {

        MainPageViewModel vm;

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = vm = new MainPageViewModel();
        }
    }


    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int countriesSelectedIndex;
        public string countriesSelectedItem;
        public List<string> countries;
        public int count;

        private string lblPicker;
        public string LblPicker
        {
            get
            {
                return lblPicker;
            }
            set
            {
                lblPicker = value;
                OnPropertyChanged(nameof(LblPicker));
            }
        }

		public int CountriesSelectedIndex
		{
			get
			{
				Debug.WriteLine("Selected Index Name: " + listCountries.ElementAt(countriesSelectedIndex).Name);
                Debug.WriteLine("Selected Index Id: " + listCountries.ElementAt(countriesSelectedIndex).Id);
                Debug.WriteLine("Selected Index: " + countriesSelectedIndex);

				return countriesSelectedIndex;
			}
			set
			{
                if ((countriesSelectedIndex != value))
				{
					countriesSelectedIndex = value;

                    // Debug.WriteLine("Selected Index: " + value);

					
					OnPropertyChanged(nameof(CountriesSelectedIndex));
					// return;
				}
			}
		}

		public string CountriesSelectedItem
		{
			get
			{
                Debug.WriteLine("Selected Item1: " + countriesSelectedItem);
                return countriesSelectedItem;
			}
			set
			{
                if (countriesSelectedItem != value)
				{
                    countriesSelectedItem = value;


					//Debug.WriteLine(listCountries.ElementAt(value).Name);
					OnPropertyChanged(nameof(CountriesSelectedIndex));
					//CountriesSelectedItem = "";
                    //CountriesSelectedItem = null;
				}
			}
		}


        List<Country> listCountries = new List<Country>
		{
            new Country(){Id=1, Name="Afghanistan"},
            new Country(){Id=2, Name="Albania"},
            new Country(){Id=3, Name="Algeria"},
            new Country(){Id=4, Name="Andorra"},
            new Country(){Id=5, Name="Angola"},
			new Country(){Id=6, Name="Chile"},
			new Country(){Id=7, Name="Chile"},
			new Country(){Id=8, Name="Chile"},
			new Country(){Id=9, Name="Chile"},
			new Country(){Id=10, Name="Chile"}
		};



        /*
        public MainPageViewModel()
        {
            count = 0;
            countries = new List<string>();
            foreach (var c in listCountries)
            {
                countries.Add(c.Name);
            }

            LblPicker = "asahsbahj";
        }
        */

        public List<string> Countries => countries;

        protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}
		}
    }


    public class Country {

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
