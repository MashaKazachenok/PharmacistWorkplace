using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Web.Models
{
    public class ClientListViewModel
    {
        public List<Client> Clients { get; set; }
        public string Search { get; set; }
    }

}