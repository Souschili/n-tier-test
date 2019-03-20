using System;
using System.Collections.Generic;
using System.Text;
using BAL.Models;
using BAL.Repositories;

namespace BAL.Services
{
    public class DataService : IDataService
    {
        // Прописана зависимость и по сылке создатся класс DataRepository 
        // Мы избавлены от сылки на слой DAL что исключает "круговую" иерархию
        private IDataRepository myrepo;

        public DataService(IDataRepository repo)
        {
            this.myrepo = repo;
        }

        // вывод даных из репозитория 
        public List<Data> GetAll()
        {
            return myrepo.Select();
        }
    }
}
