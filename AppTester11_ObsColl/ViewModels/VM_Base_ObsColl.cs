using System;
using Models;
using ViewModels.Commands;
//using Microsoft.Data.Sqlite;
using Windows.ApplicationModel;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace ViewModels
{

    public class VM_Base_ObsColl : ObservableCollection<Content>
    {
        public Cmd_ADDModelPropsList Cmd_ADDModelPropsList { get; set; }
        public Cmd_RemoveModPropsList Cmd_RemoveModPropsList { get; set; }

        private Content selectedTitle;
        public Content SelectedTitle
        {
            get => selectedTitle;
            set
            {
                selectedTitle = value;
                // RaisePropertyChanged();
            }
        }

        //Declare collection and asign a few collections Items (Props n vals)
        public ObservableCollection<Content> selectedTitles =
            new ObservableCollection<Content>
            {
                new Content{Category="Helper Reminder", Title="Weekend"},
                new Content{Category="IT-Stuff", Title="Collections"},
                new Content{Category="SED-IB", Title="The Hard Sell"}
            };



        public VM_Base_ObsColl()
        {
            Cmd_ADDModelPropsList = new Cmd_ADDModelPropsList(this);
            Cmd_RemoveModPropsList = new Cmd_RemoveModPropsList(this);

            if (DesignMode.DesignModeEnabled)
            {
                for (int i = 1; i < 4; i++)
                {
                    Add(new Content()
                    {
                        Category = "Dt - Category " + 1 + i,
                        Title = "Dt - Title " + 1 + i,
                    });
                }
            }
            else
            {
                //Add(selectedTitles<Content>);
                for (int i = 1; i < 4; i++)
                {
                    Add(new Content()
                    {
                        Category = "Run Time - Category " + 1 + i,
                        Title = "Run Time - Title " + 1 + i,
                    });
                }
            }
        }


        public void ADDModelPropsList(Content content)
        {
            //Another way to write it
            Content c = new Content
            {
                Category = content.Category,
                Title = content.Title,
                MediaType = content.MediaType,
                PlayTime = content.PlayTime
            };
            Add(c);
            Debug.WriteLine(c);
        }

        public void RemoveModPropsList(Content content)
        {
            Debug.WriteLine(content);
            //Replace Class with your object type
            //while (listViewOutput.SelectedItems.Count > 0)
            //{
            Content c = new Content();
            c.Category = content.Category;
            c.Title = content.Title;
            c.MediaType = content.MediaType;
            c.PlayTime = content.PlayTime;
            Remove(c);
            //}
        }
    }
}