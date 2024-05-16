using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Architecture.Data.FileRepositories
{
    public class GestorRiego:FileRepository, IGestorRiego
    {
        private string _cultivoVirtualPath = "cultivo.json";

        private string _foldersPath {  get; set; }


        public GestorRiego(IConfiguration configuration)
        {
            _foldersPath = $"{configuration["Folders:GestorRiego"]}";
            _cultivoVirtualPath=_foldersPath+_cultivoVirtualPath;

        }

        public async Task<Cultivo> GetCultivo()
        {
            return await ReadJsonFileAsync < Cultivo>(_cultivoVirtualPath);
        
        
        }
    }
}
