using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SQL
{
    public class InitializingLists
    {
        /// <summary>
        /// When we initialize an observable collection without onproperty changed <see cref="Name"/>       
        /// we make sure that we initialize on constructor <param name="value">
        /// to note that when we do  Name = new ObservableCollection<string>(dbMenu.GetIdFromName());  its like it copys that dbmenu list to our list.
        /// 
        /// </summary>
        public ObservableCollection<string> Name { get; set; }
        public InitializingLists()
        {
            Name = new ObservableCollection<string>(dbMenu.GetIdFromName());
        }


        private void ShowMenuItems()
        {
            Name.Clear();
            for(int i = 0; i < dbMenu.GetIdFromName().Count; i++)
            {
                Name.Add(dbMenu.GetIdFromName()[i]);
            }
        }

    }

    internal class dbMenu
    {
        internal static List<string> GetIdFromName()
        {
            throw new NotImplementedException();
        }
    }
}
