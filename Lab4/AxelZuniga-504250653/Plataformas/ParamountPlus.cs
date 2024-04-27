using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.AxelZuniga_504250653.Plataformas
{
    public class ParamountPlus
    {
        public string name {  get; set; }


        public ParamountPlus(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Name: {name}";
        }

    }
}
