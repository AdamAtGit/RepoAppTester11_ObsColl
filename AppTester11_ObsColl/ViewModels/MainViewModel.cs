//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Input;

//namespace AppTester11_ObsColl.ViewModels
//{
//   public class MainViewModel
//    {


//        #region - Private Properties -
//        private Team _selectedTeam;
//        private Soldier _selectedSoldier;
//        #endregion // - Private Properties -

//        #region // - Public Properties -
//        public ObservableCollection<Soldier> Soldiers { get; set; }
//        public ObservableCollection<Team> Teams { get; }
//        public Team SelectedTeam
//        {
//            get => _selectedTeam;
//            set
//            {
//                _selectedTeam = value;
//                RaisePropertyChanged(nameof(SelectedTeam));
//            }
//        }
//        public Soldier SelectedSoldier
//        {
//            get => _selectedSoldier;
//            set
//            {
//                _selectedSoldier = value;
//                RaisePropertyChanged(nameof(SelectedSoldier));
//            }
//        }
//        #endregion // - Public Properties -

//        #region // - Commands -
//        public ICommand DeleteTeamCommand { get; private set; }
//        public ICommand AddSoldierDialogCommand { get; private set; }
//        #endregion // - Commands -

//        #region  - Services -
//        public IDialogService AddSoldierDialogService { get; private set; }
//        #endregion // - Services -


//        #region - Constructors -
//        public MainViewModel()
//        {
//            Soldiers = new ObservableCollection<Soldier>();
//            Teams = new ObservableCollection<Team>();

//            Soldiers.CollectionChanged += Soldiers_CollectionChanged;
//            Teams.CollectionChanged += Teams_CollectionChanged;

//            DeleteTeamCommand = new RelayCommand(DeleteTeam);
//            AddSoldierDialogCommand = new RelayCommand(AddSoldierDialog);

//            AddSoldierDialogService = new AddSoldierDialogService();
//        }

//        #endregion // - Constructors -

//    }
//}
