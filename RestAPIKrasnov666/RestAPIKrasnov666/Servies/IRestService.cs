using RestAPIKrasnov666.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIKrasnov666.Servies
{
    public interface IRestService
    {
        Task <List<EntryModel>> GetListEntrylist();
    }
}
