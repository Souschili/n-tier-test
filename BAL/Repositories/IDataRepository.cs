using BAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Repositories
{
    public interface IDataRepository
    {
        List<Data> Select();
    }
}
