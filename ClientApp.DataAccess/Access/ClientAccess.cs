using ClientApp.DataAccess.Contract;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using ClientApp.DataAccess.Consts;
using System.Threading.Tasks;
using ClientApp.Models.Entities;
using System.Runtime.CompilerServices;

namespace ClientApp.DataAccess.Access
{
    public class ClientAccess : IClientAccess
    {
        public async Task<List<Client>> ReadData()
        {
            using (StreamReader read = new StreamReader(Constants.Ruta))
            {
                char[] delimiterChars = { ' ', ',', '.', ':', '\t', '\n', '\r' };
                string data = await read.ReadToEndAsync();
                string[] arrData = data.Split(delimiterChars);
                return new List<Client>()
                {
                    new Client()
                    {
                        Code = Convert.ToInt32(arrData[0]),
                        Name = Convert.ToString(arrData[1]),
                        State = Convert.ToInt32(arrData[2]),
                        Picture = ""
                    },
                    new Client()
                    {
                        Code = Convert.ToInt32(arrData[4]),
                        Name = Convert.ToString(arrData[5]),
                        State = Convert.ToInt32(arrData[6]),
                        Picture = "~\\images\\F1.jpg"
                    },
                    new Client()
                    {
                        Code = Convert.ToInt32(arrData[8]),
                        Name = Convert.ToString(arrData[9]),
                        State = Convert.ToInt32(arrData[10]),
                        Picture = "~\\images\\F2.jpg"
                    },
                    new Client()
                    {
                        Code = Convert.ToInt32(arrData[12]),
                        Name = Convert.ToString(arrData[13]),
                        State = Convert.ToInt32(arrData[14]),
                        Picture = "~\\images\\F3.jpg"
                    }
                };
            }
        }
    }
}
