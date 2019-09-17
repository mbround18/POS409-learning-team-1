using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebService.Models;
using System.IO;
using System.Web.Services;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoadDataFromTextFile" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LoadDataFromTextFile.svc or LoadDataFromTextFile.svc.cs at the Solution Explorer and start debugging.
    public class LoadDataFromTextFile : ILoadDataFromTextFile
    {
        //public void DoWork()
        //{
        //}
        [WebMethod]
        public List<Address> LoadData()
        {
            string dataFilePath = @"MOCK_DATA.csv";
            var query = from line in File.ReadAllLines(dataFilePath).Skip(1)
                        where line.Length > 1
                        select Address.ParseFromTextFile(line);
            return query.ToList();
        }

  
    }
}
