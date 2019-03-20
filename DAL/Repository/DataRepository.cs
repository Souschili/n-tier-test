using BAL.Models;
using BAL.Repositories;
using DAL.EF;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repository
{
    // Так как слой сервисов выше то мы можем референсить его в данном случае интерфейс
    public class DataRepository:IDataRepository
    {
        // приватное поле где наш датаконтекст пропишем зависимости в стартапе 
        private DataContext _context;

        public DataRepository(DataContext context)
        {
            this._context = context;

            //бд пустая и запускается в памяти,мы запишем пару значений для теста
            var list = new Data[] {new Data("Some text for example"),
                new Data("DAL-Data Accses Layer"),
                new Data("BAL-Bissnes Accses Layer")}; 
                                 
            _context.AddRange(list);
            _context.SaveChanges();

        }

        public List<Data> Select()
        {
            return _context.Datas.ToList();
        }
    }
}
