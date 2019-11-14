
using Common.CollaboratorModel;
using FundooManager.Interface;
using FundooRepository.FundooInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    public class CollaboratorManager : ICollaborator
    {
        private readonly ICollaboratorRepo collaboratorRepo;
        public CollaboratorManager (ICollaboratorRepo collaboratorRepo)
        {
            this.collaboratorRepo = collaboratorRepo;
        }
        public async Task<string> AddCollaborator(CollaboratorModel collaboratorModel)
        {
            try
            {
                await this.collaboratorRepo.AddCollaborator(collaboratorModel);
                return "AddCollaborator Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string> UpdateCollaborator(CollaboratorModel collaboratorModel)
        {
            try
            {
                await this.collaboratorRepo.UpdateCollaborator(collaboratorModel);
                return "UpdateCollaborator Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string> DeleteCollaborator(int Id)
        {
            try
            {
                await this.collaboratorRepo.DeleteCollaborator( Id);
                return "DeleteCollaborator Successfully";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public  List<CollaboratorModel> List(int Noteid)
        {
            try
            {
                var result = this.collaboratorRepo.ListCollaborator(Noteid);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
