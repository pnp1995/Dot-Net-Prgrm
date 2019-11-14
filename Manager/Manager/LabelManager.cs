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
        public async Task<string>Add(LabelModel labelModel)
        {
            try
            {
                await this.labelRepo.Addlabel(labelModel);
                return "Added Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string>Update(LabelModel labelModel)
        {
            try
            {
                await this.labelRepo.UpdateLabel(labelModel);
                return "Update Successfully";
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string>Delete(int Id)
        {
            try
            {
                await this.labelRepo.DeleteLabel(Id);
                return "Delete Successfully";
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<LabelModel>List(string Email)
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
