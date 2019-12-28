using Common.LabelModel;
using FundooRepository.Context;
using FundooRepository.FundooInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public class LabelRepository :ILabelRepo
    {
        private readonly UserContext userContext;
        public LabelRepository (UserContext userContext)
        {
            this.userContext = userContext;
        }       
        public Task Addlabel(LabelModels labelModel, String email)
        {
            labelModel.Email = email;
            LabelModels labelModel1 = new LabelModels()
            {
                Email = labelModel.Email,
                Id = labelModel.Id,
                Label = labelModel.Label,
            };
            userContext.LabelDetail.Add(labelModel);
            return Task.Run(() => userContext.SaveChanges());
        }
        public Task UpdateLabel(LabelModels labelModel, String email)
        {
            LabelModels label = userContext.LabelDetail.Where(i => i.Id == labelModel.Id).FirstOrDefault();
            if(label != null)
            {
                label.Email = email;
                label.Label = labelModel.Label;
                userContext.LabelDetail.Update(label);
            }
            return Task.Run(() => userContext.SaveChanges());
        }
        public Task DeleteLabel(int Id, String Email)
        {
            LabelModels label = userContext.LabelDetail.Where(i => i.Id == Id).FirstOrDefault();
            if(label != null)
            {
                userContext.LabelDetail.Remove(label);
            }
            return Task.Run(() => userContext.SaveChanges());
        }
        public List<LabelModels> ListofLabel(string Email)
        {
            bool label = userContext.LabelDetail.Any(p => p.Email == Email);
            if (label)
            {
                return userContext.LabelDetail.Where(p => p.Email == Email).ToList();
            }
            else
            {
                return null;
            }       
        } 
    }
}
