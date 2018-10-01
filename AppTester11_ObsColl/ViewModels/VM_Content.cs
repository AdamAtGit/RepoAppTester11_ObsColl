using Models;
using System;
using System.Collections.ObjectModel;
using ViewModels.Commands;
using Windows.UI.Xaml.Controls;

namespace ViewModels
{
    public class VM_Content : Notification
    {
        public Cmd_RemoveItems Cmd_RemoveItems { get; set; }

        #region Instance Fields
        public ObservableCollection<Content> _contents;
       // public RelayCommandSimple _addContentCommand;
        public RelayCommand<Content> _addContentCommand;
        public RelayCommand<Content> _deleteContentCommand;
        private string obj;

        #endregion

        #region Adams full ObsCol property
        //private ObservableCollection<Content> contentFiles = new ObservableCollection<Content>
        //{
        //    new Content("Title 12","Category 22"),
        //               new Content("Title 2","Category 2"),
        //                new Content("Title 3","Category 1"),
        //                 new Content("Title 4", "Category 19")

        //};

        //public ObservableCollection<Content> ContentFiles
        //{
        //    get => contentFiles;
        //    set
        //    {
        //        contentFiles = value;
        //        OnPropertyChanged("ContentFiles");

        //    }
        //}
        #endregion

        #region Constructors
        public VM_Content()
        {
            Cmd_RemoveItems = new Cmd_RemoveItems(this);

            #region Adams Contructor full ObsCol property
            //ContentFiles = new ObservableCollection<Content>()
            //{
            //          new Content("Title 12","Category 22"),
            //           new Content("Title 2","Category 2"),
            //            new Content("Title 3","Category 1"),
            //             new Content("Title 4", "Category 19")
            //         //new Content{Category="IT-Stuff", Title="Collections"},
            //         //new Content{Category="SED-IB", Title="The Hard Sell"}

            //};
            #endregion

            //adds sample data to Contents property (ObservableCollection<Content>)
            Contents = new ObservableCollection<Content>()
            {
                //new Content(Category="Helper Reminder", Title="Weekend"),
                new Content("Title 2","Category 2"),
                 new Content("Title 3","Category 1"),
                  new Content("Title 4", "Category 19"),
                    new Content("Title 6", "Category 39")
             };

            //Used for testing the deletion of items from ObservableCollection-------------------------------------
            Contents.RemoveAt(2);
            Contents.Add(new Content("Title 5", "category 4"));
          
            //Button command methods are added to delegates
            AddContentCommand = new RelayCommand<Content>(DoAddContent);
            // DeleteContentCommand = new RelayCommand<Content>(DoDeleteContent);
           
            DeleteContentCommand = new RelayCommand<Content>(DoDeleteContent);
        }

        #endregion

        #region Properties
        #region Properties - ObservableCollection<Content> Contents
        public ObservableCollection<Content> Contents
        {
            get => _contents;
            set
            {
                _contents = value;
                OnPropertyChanged("Contents");
            }
        }
        #endregion

        //public RelayCommandSimple AddContentCommand { get { return _addContentCommand; } set { _addContentCommand = value; } }

        public RelayCommand<Content> AddContentCommand { get { return _addContentCommand; } set { _addContentCommand = value; } }
        public RelayCommand<Content> DeleteContentCommand { get { return _deleteContentCommand; } set { _deleteContentCommand = value; } }
        //public RelayCommand DeleteContentCommand { get { return _deleteContentCommand; } set { _deleteContentCommand = value; } }

        #endregion

        #region methods
        public void RemoveItems(Content content)
        {
            this.Contents.Remove(content);
            Contents.RemoveAt(3);
            
        }

        private void DoAddContent(Content content)
        {
            var newItem = obj as string;
            if (!string.IsNullOrEmpty(newItem))
            {
                // AddContent(newItem);
                this.Contents.Add(content);
            }
        }

        private void DoDeleteContent(Content content)
        {
            this.Contents.Remove(content);
        }

        //public void AddContent(string title, string category)
        //{
        //    this.Contents.Add(new Content(title, category));

        //}

        //public void DeleteContent(Content itemToDelete)
        //{
        //    this.Contents.Remove(itemToDelete);
        //}

        //if (Contents.Contains(itemToDelete))
        //{
        //    Contents.Remove(itemToDelete);
        //}
        //}
        #endregion
    }
}
