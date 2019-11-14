using Common.LabelModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Interface
{
    public  interface ILabel
    {
        Task<string> Add(LabelModel labelModel);
        Task<string> Update(LabelModel labelModel);
        Task<string> Delete(int Id);
        List<LabelModel> List(string Email);
    }
}
