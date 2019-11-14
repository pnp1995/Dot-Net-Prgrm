using Common.LabelModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.FundooInterface
{
    public interface ILabelRepo
    { 
      Task Addlabel(LabelModel labelModel);
        Task UpdateLabel(LabelModel labelModel);
        Task DeleteLabel(int Id);
        List<LabelModel> ListofLabel(string Email);
    }
}
