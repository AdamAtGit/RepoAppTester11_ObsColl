namespace Models
{
    public class Content
    {
        #region override string 
        //public override string ToString()
        //{
        //    return Title + " ," +  Category;
        //}
        #endregion
        #region Prop Changed *in Notification.cs Instead
        //public event PropertyChangedEventHandler PropertyChanged;
        //private void OnPropertyChanged(string propName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        //}
#endregion
        public Content(string title)
        {
            Title = title;
            #region if/else designMode
            //if (DesignMode.DesignModeEnabled)
            //{
            //    Title = "Out the Door CheckList";
            //   // Category = "Human Fx";                        
            //}
            //else
            //{            
            //    Title = "RT - Out the Door CheckList";
            //   //Category = "RT - Human Fx";                
            //}
            #endregion
        }
      

       // public int Id { get; set; }

        private string title;
        public string Title
        {
            get => title;
            set
            {
                title = value;
            }
        }


        #region Other Class/Model/Record Props & Fields
        //private string category;
        //public string Category
        //{
        //    get => category;
        //    set
        //    {
        //        category = value;
        //        OnPropertyChanged("Category");
        //    }
        //}


        //private string mediaType;//Speech,Audio,Video
        //public string MediaType
        //{
        //    get => mediaType;
        //    set
        //    {
        //        mediaType = value;
        //        OnPropertyChanged("MediaType");
        //    }
        //}

        //private string playTime;
        //public string PlayTime
        //{
        //    get => playTime;
        //    set
        //    {
        //        playTime = value;
        //        OnPropertyChanged("PlayTime");
        //    }
        //}

        //private string titleSet;
        //public string TitleSet
        //{
        //    get => titleSet;
        //    set
        //    {
        //        titleSet = value;
        //        OnPropertyChanged("TitleSet");
        //    }
        //}

        //private string playSet;
        //public string PlaySet
        //{
        //    get => playSet;
        //    set
        //    {
        //        playSet = value;
        //        OnPropertyChanged("PlaySet");
        //    }
        //}

        //private bool repeatsIsOn;
        //public bool RepeatsIsOn
        //{
        //    get => repeatsIsOn;
        //    set
        //    {
        //        repeatsIsOn = value;
        //        OnPropertyChanged("RepeatsIsOn");
        //    }
        //}
        #endregion

        #region Remaining Fields
        //public string TitleNo { get; set; }

        //public string FileName { get; set; }

        //public string Path { get; set; }

        //public string RepeatIntervalName { get; set; }

        //public string MediaUses { get; set; }
        #endregion

    }
}