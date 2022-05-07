using RestAPIKrasnov666.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIKrasnov666.Servies
{
	public class RestManager
	{
		IRestService restService;

		public RestManager(IRestService service)
		{
			restService = service;
		}

		public Task<List<EntryModel>> GetTasksAsync()
		{
			return restService.GetListEntrylist();
		}
	}
}
