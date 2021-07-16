using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Solid_SRP_
{
    public interface IUserRepository
    {
        public void Load();

        public void Save();

        public void Update();

        public void Delete();
    }
}