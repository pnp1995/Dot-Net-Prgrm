using Common.LabelModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.FundooInterface
{
    public interface ILabelRepo
    { 
      Task Addlabel(LabelModel labelModel,String  email);
        Task UpdateLabel(LabelModel labelModel, String email);
        Task DeleteLabel(int Id, String email);
        List<LabelModel> ListofLabel(String Email);
    }
}
