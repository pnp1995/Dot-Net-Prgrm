using Common.LabelModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Interface
{
    public  interface ILabel
    {
        Task<string> Add(LabelModels labelModel,String Email);
        Task<string> Update(LabelModels labelModel,String Email);
        Task<string> Delete(int Id,String Email);
        List<LabelModels> List(string Email);
    }
}
