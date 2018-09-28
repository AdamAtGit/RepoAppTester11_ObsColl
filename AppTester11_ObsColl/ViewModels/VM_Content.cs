using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using Models;
using ViewModels.Commands;

namespace ViewModels 
{
    public class VM_Content : Notification
    {
        #region Instance Fields
        private ObservableCollection<Content> _contents;
        private RelayCommandSimple _addContentCommand;
        private RelayCommand<Content> _deleteContentCommand;

        #endregion

        #region Constructors
        public VM_Content()
        {
            //adds sample data to Contents property (ObservableCollection<Content>)
            Contents = new ObservableCollection<Content>() { new Content("Sample text 1"), new Content("Sample text 2") };

            //Used for testing the deletion of items from ObservableCollection-------------------------------------
            Contents.RemoveAt(1);
            Contents.Add(new Content("Sample text 3"));
            //foreach (var item in Contents)
            //{
            //    if (item.Title == "Sample text 3")
            //    {
            //        DoDeleteContent(item);
            //        break;
            //    }
            //}
            //------------------------------------------------------

            //Button command methods are added to delegates
            AddContentCommand = new RelayCommandSimple(DoAddContent);
            DeleteContentCommand = new RelayCommand<Content>(DoDeleteContent);
        }

        #endregion

        #region Properties
        public ObservableCollection<Content> Contents { get { return _contents; } set { _contents = value; OnPropertyChanged("Contents"); } }


        public RelayCommandSimple AddContentCommand { get { return _addContentCommand; } set { _addContentCommand = value; } }

       
        public RelayCommand<Content> DeleteContentCommand { get { return _deleteContentCommand; } set { _deleteContentCommand = value; } }
        //public RelayCommand DeleteContentCommand { get { return _deleteContentCommand; } set { _deleteContentCommand = value; } }

        #endregion

        #region methods

        private void DoAddContent(object obj)
        {
            var newItem = obj as string;
            if (!string.IsNullOrEmpty(newItem))
            {
                AddContent(newItem);
            }
        }

        //Work in progress
        private void DoDeleteContent(object obj)
        {
            //Used when the XAML Delete Button invokes this method
            TextBlock textBlockSender = obj as TextBlock;
          
            Content itemToDelete = textBlockSender.DataContext as Content;

            //Used when the constuctor invokes this method, for testing purposes------------
            //Content itemToDelete = obj as Content;
            //--------------------------------------------------------

            foreach (Content content in this.Contents)
            {
                if (content.Title == itemToDelete.Title)
                {
                    //int contentIndex = Contents.IndexOf(content);
                    //Contents.RemoveAt(contentIndex);
                    DeleteContent(content);
                    break;
                }
            }
            //if (Contents.Contains(itemToDelete))
            //{
            //    Contents.Remove(itemToDelete);
            //}
        }

        public void AddContent(string title)
        {
            this.Contents.Add(new Content(title));
        }

        public void DeleteContent(Content itemToDelete)
        {
            this.Contents.Remove(itemToDelete);
        }
        #endregion



    }
}
