using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.EstebanBonilla_118700462;
public class Deku : IDetroitSmash, IDelawareSmash
{
    public string Quirk { get; set; }
    public string Alias { get; set; }

    protected Deku(string quirk, string alias)
    {
        this.Quirk = quirk;
        this.Alias = alias;
    }

    public void FullCowl()
    {
        throw new NotImplementedException();
    }

    public void DetroitSmash()
    {
        throw new NotImplementedException();
    }

    public void DelawareSmash()
    {
        throw new NotImplementedException();
    }
}