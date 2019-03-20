using BAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Services
{
    public interface IDataService
    {
        List<Data> GetAll();
    }
}
