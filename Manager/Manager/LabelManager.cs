using Common.LabelModel;
using FundooManager.Interface;
using FundooRepository.FundooInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
  public class LabelManager : ILabel
    {
        private readonly ILabelRepo labelRepo;
        public LabelManager(ILabelRepo labelRepo)
        {
            this.labelRepo =labelRepo;
        }
        public async Task<string>Add(LabelModels labelModel,String Email)
        {
            try
            {
                await this.labelRepo.Addlabel(labelModel,Email);
                return "Added Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string>Update(LabelModels labelModel,String Email)
        {
            try
            {
                await this.labelRepo.UpdateLabel(labelModel,Email);
                return "Update Successfully";
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string>Delete(int Id,String Email)
        {
            try
            {
                await this.labelRepo.DeleteLabel(Id, Email);
                return "Delete Successfully";
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<LabelModels>List(string Email)
        {
            try
            {
                var result = this.labelRepo.ListofLabel(Email);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
