using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Solid_SRP_
{
    public interface IUser
    {
        public IEnumerable<object> GetItems();

        public int GetItemsCount();

        public void AddItem(object item);

        public void DeleteItem(int id);

        public void PrintUser();

        public void ShowUser();

        public void Load();
                          
        public void Save();

        public void Update();
                            
        public void Delete();
    }
}
