using Common.LabelModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Interface
{
    public  interface ILabel
    {
        Task<string> Add(LabelModel labelModel,String Email);
        Task<string> Update(LabelModel labelModel,String Email);
        Task<string> Delete(int Id,String Email);
        List<LabelModel> List(string Email);
    }
}
