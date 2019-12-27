using First_aid_kit.Cabal.Model;
using First_aid_kit.Cabal.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;


namespace First_aid_kit.Cabal.ViewModel
{
    public class AppViewModel : INotifyPropertyChanged
    {
        public AppViewModel()
        {
            DrugCollection = new ObservableCollection<DrugModel>();

            myKitCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new KitContent(this));
            });

            NewDrugCommand = new Command(async ()  =>
            {

                await Application.Current.MainPage.Navigation.PushAsync(new NewDrugPage(this));
            });

            CreateDrugCommand = new Command(async () =>
            {
                var drug = new DrugModel
                {
                    Name = DrugName,
                    bestBefour = BestBefour
                };

                DrugCollection.Add(drug);

                DrugName = string.Empty;
                BestBefour = DateTime.Now;

                await Application.Current.MainPage.Navigation.PopAsync();
            });

            DrugSelectedCommand = new Command(async () =>
            {
                if (SelectedDrug is null)
                    return;
                SelectedDrugName = SelectedDrug.Name;
                SelectedDrugBestBefour = SelectedDrug.bestBefour.ToString();

                var drugOverviev = new DrugOverview(this);
                

                await Application.Current.MainPage.Navigation.PushAsync(drugOverviev);

                SelectedDrug = null;
            });
        }


        public event PropertyChangedEventHandler PropertyChanged;

        string drugName;
        public string DrugName
        {
            get => drugName;
            set
            {
                drugName = value;
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DrugName)));

                //CreateDrugCommand.ChangeCanExecute();
            }
        }

        DateTime bestBefour;
        public DateTime BestBefour
        {
            get => bestBefour;
            set
            {
                bestBefour = value;
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BestBefour)));

               // CreateDrugCommand.ChangeCanExecute();
            }
        }

        DrugModel selectedDrug;
        public DrugModel SelectedDrug
        {
            get => selectedDrug;
            set
            {
                selectedDrug = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedDrug)));
            }
        }

        public string SelectedDrugName
        {
            get;
            set;
        }

        public string SelectedDrugBestBefour
        {
            get;
            set;
        }

        public ObservableCollection<DrugModel> DrugCollection { get; }


        public Command myKitCommand { get; }
        public Command NewDrugCommand { get; }
        public Command CreateDrugCommand { get; }
        public Command DrugSelectedCommand { get; }
    }


}
